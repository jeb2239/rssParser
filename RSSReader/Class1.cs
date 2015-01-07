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

            XmlReader readRss = XmlReader.Create("http://www.bloomberg.com/feed/podcast/surveillance.xml");
            SyndicationFeed syncfeed = SyndicationFeed.Load(readRss);
            readRss.Close();
            foreach (var item in syncfeed.Items)
            {
               String title= item.Title.Text;
               Console.WriteLine(title);
               Console.WriteLine();
               //String summary = item.Summary.Text;
           //    Console.WriteLine(summary);
              
            }


            Console.ReadKey();
        }
    }
}
