using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS__Craigslist_Scraper
{
    public partial class Form1 : Form
    {
        ConcurrentQueue<string> cityLinkQueue = new ConcurrentQueue<string>();
        ConcurrentQueue<string> listingDirectoryQueue = new ConcurrentQueue<string>();
        ConcurrentQueue<string> individualListingQueue = new ConcurrentQueue<string>();
        ConcurrentQueue<string> phoneNumberResults = new ConcurrentQueue<string>();
        ConcurrentQueue<string> numberPages = new ConcurrentQueue<string>();
        string lastSuccessfulUrl;
        CancellationTokenSource cts = new CancellationTokenSource();
        List<string> extractedNumbers = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            #region set aside code
            //if (webBrowser1.Url.ToString().Contains("http://www.craigslist.org/about/sites#US") && firstTime)
            //{
            //    HtmlElementCollection currPageLinks = webBrowser1.Document.GetElementsByTagName("A");
            //    foreach (HtmlElement item in currPageLinks)
            //    {
            //        if (!item.GetAttribute("href").ToString().Contains("sites") && !item.GetAttribute("href").ToString().Contains(".ca") && item.GetAttribute("href").ToString().Contains(".org"))
            //        {
            //            cityLinkQueue.Add(item.GetAttribute("href").ToString());
            //        }
            //    }
            //    cityLinkQueue = cityLinkQueue.Distinct().ToList();
            //}
            //if (listingScrapeStarted && individualListingQueue.Count < 5000)
            //{
            //    webBrowser1.Navigate(new Uri(cityLinkQueue.ElementAt(0)) + "search/sss/");
            //    listingLinkGrabber();
            //    cityLinkQueue.Remove(cityLinkQueue.ElementAt(0));

            //}
            //if (individualPageScrape && individualListingQueue.Count > 0)
            //{
            //    webBrowser1.Navigate(new Uri(individualListingQueue.ElementAt(0)));
            //    numScraper();
            //    individualListingQueue.Remove(individualListingQueue.ElementAt(0));

            //    var lines = this.textBox5.Lines;
            //    var newLines = lines.Skip(1);
            //    this.textBox5.Lines = newLines.ToArray();

            //}
            //if (numPageScrape && numberPages.Count > 0)
            //{
            //    webBrowser1.Navigate(new Uri(numberPages.ElementAt(0)));
            //    numExtractor();
            //    numberPages.Remove(numberPages.ElementAt(0));

            //    var lines = this.tbScrape.Lines;
            //    var newLines = lines.Skip(1);
            //    this.tbScrape.Lines = newLines.ToArray();
            //}
            #endregion
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            var html = wb.DownloadString("http://www.craigslist.org/about/sites#US");
            List<string> temp = ScraperLogic.FindCities(html, "http://www.craigslist.org");
            cityLinkQueue = new ConcurrentQueue<string>(temp);
            MessageBox.Show("Done");
        }

        private void listingLinkGrabber()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numScraper()
        {
            //HtmlElementCollection currNumPages = webBrowser1.Document.GetElementsByTagName("A");
            //foreach (HtmlElement item in currNumPages)
            //{
            //    if (listingIdPattern.IsMatch(item.GetAttribute("href").ToString()) && item.GetAttribute("href").ToString().Contains("fb"))
            //    {
            //        numberPages.Add(item.GetAttribute("href").ToString());
            //        numberPages = numberPages.Distinct().ToList(); //remove duplcates as it goes along
            //        foreach (var i in numberPages)
            //        {
            //            tbScrape.AppendText(i + Environment.NewLine);
            //        }
            //    }
            //}
        }

        private void numExtractor()
        {
            //Regex phoneNumberPattern = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            //Regex digitsOnly = new Regex(@"[^\d]");
            //var numToCheck = webBrowser1.DocumentText.ToString().Split(' ');
            //foreach(var word in numToCheck)
            //{
            //    digitsOnly.Replace(word, "");
            //}
            //var match =
            //    from i in numToCheck
            //    where phoneNumberPattern.IsMatch(i)
            //    select i;

            //foreach (var i in match)
            //{
            //    extractedNumbers.Add(i);
            //    textBox4.AppendText(i + Environment.NewLine);
            //}
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            //var counter = 0;
            await Task.Run(() => {
                Parallel.ForEach(cityLinkQueue, item =>
                {

                    Uri uri = new Uri("http://craigslist.org");
                    WebClient wb = new WebClient();
                    uri = new Uri(item);
                    var host = uri.Host;
                    string html;
                    try
                    {
                        html = wb.DownloadString(item);
                        lastSuccessfulUrl = item;
                    }
                    catch
                    {
                        html = wb.DownloadString(lastSuccessfulUrl);
                    }

                    item = ScraperLogic.urlFormatChecker(item);
                    List<string> temp = ScraperLogic.FindPagesWithListings(html, item);
                    foreach (var i in temp)
                    {
                        listingDirectoryQueue.Enqueue(i);
                    }
                    label2.BeginInvoke(new Action(() =>
                    {
                        label2.Text = listingDirectoryQueue.Count().ToString();
                    }));
                    //counter++;
                    //if(counter % 20 == 0)
                    //{
                    //    string[] tempArr = listingDirectoryQueue.ToArray();
                    //    textBox5.BeginInvoke(new Action(() =>
                    //    {
                    //        textBox5.Lines = tempArr;
                    //    }));
                    //}
                });
            },cts.Token);

            MessageBox.Show("Done");
            cts = new CancellationTokenSource();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Parallel.ForEach(listingDirectoryQueue, item =>
                {
                    Uri uri = new Uri("http://craigslist.org");
                    WebClient wb = new WebClient();
                    uri = new Uri(item);
                    var host = uri.Host;
                    string html;
                    try
                    {
                        html = wb.DownloadString(item);
                        lastSuccessfulUrl = item;
                    }
                    catch
                    {
                        html = wb.DownloadString(lastSuccessfulUrl);
                    }

                    item = ScraperLogic.urlFormatChecker(item);
                    List<string> temp = ScraperLogic.FindIndividualListings(html, item);
                    foreach (var i in temp)
                    {
                        individualListingQueue.Enqueue(i);
                    }
                    label1.BeginInvoke(new Action(() =>
                    {
                        label1.Text = individualListingQueue.Count().ToString();
                    }));
                });
            }, cts.Token);

            MessageBox.Show("Done");
            cts = new CancellationTokenSource();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void statusChecker()
        {

        }


    }
}
