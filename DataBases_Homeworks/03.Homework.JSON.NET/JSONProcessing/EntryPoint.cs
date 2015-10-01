namespace JSONProcessing
{
    using System;
    using System.Net;
    using System.Xml;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    class EntryPoint
    {
        private const string RssUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
        private const string XmlPath = "..//..//TelerikAcademyYoutubeFeed.xml";

        static void Main()
        {
            // Download  the RSS file
            WebClient client = new WebClient();
            client.DownloadFile(RssUrl, XmlPath);
            Console.WriteLine("RSS document has been saved..\n");

            XmlDocument doc = new XmlDocument();
            doc.Load(XmlPath);

            // Parse teh XML from the feed to JSON
            string json = JsonConvert.SerializeXmlNode(doc);

            // Using LINQ-to-JSON select all the video titles and print the on the console
            JObject jsonObj = JObject.Parse(json);

            var videoTitles = jsonObj["feed"]["entry"].Select(x => x["title"]);

            Console.WriteLine("All video titles are: ");
            foreach (var title in videoTitles)
            {
                Console.WriteLine(title);
            }

            // Parse the videos' JSON to POCO
            var jsonVideos = jsonObj["feed"]["entry"];
            var pocoVideos = new List<Video>();

            foreach (var item in jsonVideos)
            {
                pocoVideos.Add(JsonConvert.DeserializeObject<Video>(item.ToString()));
            }

            Console.WriteLine(pocoVideos[0].Link.Href);

            // Using the POCOs create a HTML page that shows all videos from the RSS
            //Use<iframe>
            //Provide a links, that nagivate to their videos in YouTube
            var html = new StringBuilder();
            html.AppendLine("<!DOCTYPE html><html><body>");
            foreach (var video in pocoVideos)
            {
                html.AppendFormat("</p>Name: {0}</p>", video.Title);
                html.AppendFormat("<p><iframe src=\"http://www.youtube.com/embed/{0}?autoplay=0\"></iframe>", video.Id);
                html.AppendFormat("</p><p><a href=\"{0}\">Go to youtube</a></p>", video.Link.Href);
            }
            html.AppendLine("</body></html>");

            File.WriteAllText("../../videos.html", html.ToString());




        }
    }
}
