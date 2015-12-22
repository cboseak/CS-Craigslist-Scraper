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
        bool firstTime = true;
        bool listingScrapeStarted = false;
        bool numScrapeStarted = false;
        Regex listingIdPattern = new Regex(@"\d{10}");
        Regex phoneNumberPattern1 = new Regex(@"\D(\d{3}\s\d{3}\s\d{4})\D");
        Regex emailPattern = new Regex(@"	
^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
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
            if (listingScrapeStarted && individualListingQueue.Count < 500)
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
    }
}
