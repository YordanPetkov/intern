using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Linq;
using System.Net;
using Newtonsoft.Json.Linq;

namespace _01.JSONtask
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string fileName = "../../../telerikVideosInfo.xml";

            DownloadXmlFile(url);
            TakeXmlNode(fileName);
            var json = JsonConvert.SerializeXNode(TakeXmlNode(fileName));

            JObject telerikFeed = JObject.Parse(json);
            IList<string> videoTitles = telerikFeed["feed"]["entry"].Select(entry => (string)entry["title"]).ToList();

            foreach (var title in videoTitles)
            {
                Console.WriteLine(title);
            }
        }

        public static void DownloadXmlFile(string url)
        {
            var client = new WebClient();
            client.DownloadFile(url, "../../../telerikVideosInfo.xml");
        }

        public static XDocument TakeXmlNode(string fileName)
        {
            var node = XDocument.Load(fileName);
            return node;
        }
    }
}
