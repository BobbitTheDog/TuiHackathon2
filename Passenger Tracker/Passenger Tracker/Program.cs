using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Passenger_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //string testLocation = ConfigurationManager.AppSettings["location"];
            //Console.WriteLine(testLocation);
            //getRequest("http://www.youtube.com");
            string token;
            Console.ReadLine();

        }


        async static void postRequest(string url)
        {
            HttpContent content = new FormUrlEncodedContent(<KeyValuePair<string, string>>);
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.PostAsync("http://www.youtube.com", content))
            using (HttpContent content = response.Content)
            {

                string myContent = await content.ReadAsStringAsync();
                Console.WriteLine(myContent);
            }
        }
    }
}
