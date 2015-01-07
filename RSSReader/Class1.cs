using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;

namespace RSSReader
{
    class Tester
    {
        public static void Main()
        {

            XmlReader readRss = XmlReader.Create("http://rss.cnn.com/rss/money_latest.rss");
            SyndicationFeed syncfeed = SyndicationFeed.Load(readRss);
            readRss.Close();
            foreach (var item in syncfeed.Items)
            {
               String title= item.Title.Text;
               Console.WriteLine(title);
            }


            Console.ReadKey();
        }
    }
}
