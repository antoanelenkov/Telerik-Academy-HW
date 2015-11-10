namespace ConsoleApplication1
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Linq;

    class Startup
    {
        /*Write a console application, which searches for news articles by given a query string and a count of articles to retrieve.
        The application should ask the user for input and print the Titles and URLs of the articles.
        For news articles search, use the Feedzilla API and use one of WebClient, HttpWebRequest or HttpClient.*/

        static void Main()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://jsonplaceholder.typicode.com");
            var artists = GetPosts(httpClient).Result;
            var reponseMsg= AddPost(httpClient).Result;

            Console.WriteLine(artists);
            Console.WriteLine(reponseMsg);
        }

        private static async Task<string> GetPosts(HttpClient httpClient)
        {
            var response =  httpClient.GetAsync("/posts").Result;

            return response.Content.ReadAsStringAsync().Result;
        }

        private static async Task<string> AddPost(HttpClient httpClient)
        {
            var content = new StringContent("{\"Name\":\"ArtistName2\",\"DateOfBirth\":\"12 / 31 / 2008\"}");
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = httpClient.PostAsync("/posts", content).Result;

            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
