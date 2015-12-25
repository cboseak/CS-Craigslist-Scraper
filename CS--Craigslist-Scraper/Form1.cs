using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS__Craigslist_Scraper
{
    public partial class Form1 : Form
    {
        List<string> cityLinkQueue = new List<string>();
        List<string> individualListingQueue = new List<string>();
        List<string> phoneNumberResults = new List<string>();
        List<string> numberPages = new List<string>();
        List<string> extractedNumbers = new List<string>();
        bool firstTime = true;
        bool listingScrapeStarted = false;
        bool numScrapeStarted = false;
        bool numPageScrape = false;
        Regex listingIdPattern = new Regex(@"\d{10}");
        Regex phoneNumberPattern1 = new Regex(@"\D(\d{3}\s\d{3}\s\d{4})\D");
        public Form1()
        {
            InitializeComponent();
            webBrowser1.AllowNavigation = true;
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.ToString().Contains("http://www.craigslist.org/about/sites#US") && firstTime)
            {
                HtmlElementCollection currPageLinks = webBrowser1.Document.GetElementsByTagName("A");
                foreach (HtmlElement item in currPageLinks)
                {
                    if (!item.GetAttribute("href").ToString().Contains("sites") && !item.GetAttribute("href").ToString().Contains(".ca") && item.GetAttribute("href").ToString().Contains(".org"))
                    {
                        cityLinkQueue.Add(item.GetAttribute("href").ToString());
                    }
                }
                cityLinkQueue = cityLinkQueue.Distinct().ToList();
            }
            if (listingScrapeStarted && individualListingQueue.Count < 5000)
            {
                webBrowser1.Navigate(new Uri(cityLinkQueue.ElementAt(0)) + "search/sss/");
                listingLinkGrabber();
                cityLinkQueue.Remove(cityLinkQueue.ElementAt(0));
            }
            if (numScrapeStarted && individualListingQueue.Count > 0)
            {
                webBrowser1.Navigate(new Uri(individualListingQueue.ElementAt(0)));
                numScraper();
                individualListingQueue.Remove(individualListingQueue.ElementAt(0));
            }
            if (numPageScrape && numberPages.Count > 0)
            {
                webBrowser1.Navigate(new Uri(numberPages.ElementAt(0)));
                numExtractor();
                numberPages.Remove(numberPages.ElementAt(0));
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            listingScrapeStarted = true;
        }

        private void listingLinkGrabber()
        {

            if (webBrowser1.Url.ToString().Contains("search/sss/"))
            {
                HtmlElementCollection currPageLinks = webBrowser1.Document.GetElementsByTagName("A");
                foreach (HtmlElement item in currPageLinks)
                {
                        if (listingIdPattern.IsMatch(item.GetAttribute("href").ToString()))
                        {
                            individualListingQueue.Add(item.GetAttribute("href").ToString());
                        }
                }
            }
            firstTime = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listingScrapeStarted = false;
        }

        private void numScraper()
        {
            HtmlElementCollection currNumPages = webBrowser1.Document.GetElementsByTagName("A");
            foreach (HtmlElement item in currNumPages)
            {
                if (listingIdPattern.IsMatch(item.GetAttribute("href").ToString()) && item.GetAttribute("href").ToString().Contains("fb"))
                {
                    numberPages.Add(item.GetAttribute("href").ToString());
                    tbScrape.AppendText(item.GetAttribute("href").ToString() + Environment.NewLine);

                }
            }

        }

        private void numExtractor()
        {
            if(phoneNumberPattern1.IsMatch(webBrowser1.DocumentText))
            {
                extractedNumbers.Add(phoneNumberPattern1.Match(webBrowser1.DocumentText).ToString());
                textBox4.AppendText(phoneNumberPattern1.Match(webBrowser1.DocumentText).ToString() + Environment.NewLine);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            listingScrapeStarted = false;
            numScrapeStarted = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numScrapeStarted = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numPageScrape = true;
            button5.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numScrapeStarted = false;
            listingScrapeStarted = false;
            webBrowser1.Refresh();
            numPageScrape = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }


    }
}
