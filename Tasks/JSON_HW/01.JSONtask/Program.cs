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
            var url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            var client = new WebClient();
            var xml = client.DownloadString(url);
            var node = XDocument.Parse(xml);
            var json = JsonConvert.SerializeXNode(node);
            JObject feed = JObject.Parse(json);
            IList<string> videoTitles = feed["feed"]["entry"].Select(entry => (string)entry["title"]).ToList();

            Console.OutputEncoding = Encoding.UTF8;
            foreach (var title in videoTitles)
            {
                Console.WriteLine(title);
            }

        }
    }
}
