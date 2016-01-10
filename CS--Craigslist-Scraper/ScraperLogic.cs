using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CS__Craigslist_Scraper
{
    class ScraperLogic
    {
        static Regex listingIdPattern = new Regex(@"\d{10}");
        static Regex phoneNumberPattern = new Regex(@"\D(\d{3}\s\d{3}\s\d{4})\D");
        static Regex phoneNumberPattern1 = new Regex(@"^(\([0-9]{3}\)|[0-9]{3}-)[0-9]{3}-[0-9]{4}$");

        public static List<string> FindCities(string file, string baseUrl)
        {
            List<string> list = new List<string>();

            // 1.
            // Find all matches in file.
            MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)",
                RegexOptions.Singleline);

            // 2.
            // Loop over each match.
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                LinkItem i = new LinkItem();

                // 3.
                // Get href attribute.
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""",
                RegexOptions.Singleline);
                if (m2.Success)
                {
                    i.Href = m2.Groups[1].Value;
                }
                string t = Regex.Replace(value, @"\s*<.*?>\s*", "",
                RegexOptions.Singleline);
                i.Text = t;
                if (("" + i.Href).Contains("//") && ("" + i.Href).Contains("craigslist.org") && !("" + i.Href).Contains("http"))
                {
                    list.Add("http:" + i.Href);
                }
            }
            return list;
        }
        public static List<string> FindPagesWithListings(string file, string baseUrl)
        {
            List<string> list = new List<string>();

            // 1.
            // Find all matches in file.
            MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)",
                RegexOptions.Singleline);

            // 2.
            // Loop over each match.
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                LinkItem i = new LinkItem();

                // 3.
                // Get href attribute.
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""",
                RegexOptions.Singleline);
                if (m2.Success)
                {
                    i.Href = m2.Groups[1].Value;
                }
                string t = Regex.Replace(value, @"\s*<.*?>\s*", "",
                RegexOptions.Singleline);
                i.Text = t;
                if (("" + i.Href).Contains("/search/"))
                {
                    list.Add(baseUrl + i.Href.Substring(1));
                }
            }
            return list;
        }
        public static List<string> FindIndividualListings(string file, string baseUrl)
        {
            List<string> list = new List<string>();

            // 1.
            // Find all matches in file.
            MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)",
                RegexOptions.Singleline);

            // 2.
            // Loop over each match.
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                LinkItem i = new LinkItem();

                // 3.
                // Get href attribute.
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""",
                RegexOptions.Singleline);
                if (m2.Success)
                {
                    i.Href = m2.Groups[1].Value;
                }
                string t = Regex.Replace(value, @"\s*<.*?>\s*", "",
                RegexOptions.Singleline);
                i.Text = t;
                if (!string.IsNullOrEmpty(i.Href))
                {
                    if (i.Href.Contains("//") && !i.Href.Contains("http")) { i.Href.Replace("//", ""); }
                    if (baseUrl.Contains("//") && !baseUrl.Contains("http")) { i.Href.Replace("//", ""); }
                    if (listingIdPattern.IsMatch(i.Href) )
                    {
                        if (i.Href.Contains(".craigslist.org"))
                        {
                            if (i.Href.Substring(0, 2) == "//")
                            {
                                list.Add(i.Href.Substring(2));
                            }
                            else
                            {
                                list.Add(i.Href);
                            }

                        }
                    }
                }
            }
            return list;
        }

        public static List<string> FindNumberPages(string file, string baseUrl)
        {
            Match result = Regex.Match(baseUrl, @"^.*?(?=(org))");
            List<string> list = new List<string>();

            // 1.
            // Find all matches in file.
            MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)",
                RegexOptions.Singleline);

            // 2.
            // Loop over each match.
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                LinkItem i = new LinkItem();

                // 3.
                // Get href attribute.
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""",
                RegexOptions.Singleline);
                if (m2.Success)
                {
                    i.Href = m2.Groups[1].Value;
                }
                string t = Regex.Replace(value, @"\s*<.*?>\s*", "",
                RegexOptions.Singleline);
                i.Text = t;
                if (!string.IsNullOrEmpty(i.Href) && i.Href.Contains("/reply/"))
                {
                    list.Add(result.ToString() + "org" +i.Href);
                }
            }
            return list;
        }

        public struct LinkItem
        {
            public string Href;
            public string Text;

            public override string ToString()
            {
                return Href + "\n\t" + Text;
            }
        }
        internal static string urlFormatChecker(string urlToCheck)
        {
            if (!urlToCheck.Contains("http://") && !urlToCheck.Contains("https://"))
                return "http://" + urlToCheck;
            else
                return urlToCheck;
        }
        internal static List<string> numberExtractor(string textToCheck)
        {
            List<string> list = new List<string>();
            Regex digitsOnly = new Regex(@"[^\d]");
            MatchCollection matches = Regex.Matches(textToCheck, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                RegexOptions.Singleline);

            foreach(var number in matches)
            {
                list.Add(number.ToString());
            }

            return list;
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
        public static List<string> NumberExtractor2(string file)
        {
            List<string> list = new List<string>();

            // 1.
            // Find all matches in file.
            MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)",
                RegexOptions.Singleline);

            // 2.
            // Loop over each match.
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                LinkItem i = new LinkItem();

                // 3.
                // Get href attribute.
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""",
                RegexOptions.Singleline);
                if (m2.Success)
                {
                    i.Href = m2.Groups[1].Value;
                }
                string t = Regex.Replace(value, @"\s*<.*?>\s*", "",
                RegexOptions.Singleline);
                i.Text = t;
                if (!string.IsNullOrEmpty(i.Href) && i.Href.Contains("tel:"))
                {
                    list.Add(i.Href.Substring(5,3) + "-" + i.Href.Substring(8,3) + "-" + i.Href.Substring(11,4));
                }
            }
            return list;
        }
    }
}
