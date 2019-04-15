using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using SIBENTO.Class.Model;

namespace SIBENTO.Class.Utility
{
    class ApiClient
    {
        private static readonly HttpClient client = new HttpClient();
        private static Employee employee;


        public static async Task<JObject> SendPostRequest(Dictionary<string, string> body, string url)
        {
            FormUrlEncodedContent content = new FormUrlEncodedContent(body);

            HttpResponseMessage response = await client.PostAsync(url, content);
            
            string jsonstring = await response.Content.ReadAsStringAsync();

            return JObject.Parse(jsonstring);
        }

        public static async Task<JObject> SendPutRequest(Dictionary<string, string> body, string url)
        {
            FormUrlEncodedContent content = new FormUrlEncodedContent(body);

            HttpResponseMessage response = await client.PutAsync(url, content);

            string jsonstring = await response.Content.ReadAsStringAsync();

            return JObject.Parse(jsonstring);
        }


        public static async Task<JObject> SendDelRequest(string url)
        {
            HttpResponseMessage response = await client.DeleteAsync(url);
            string jsonstring = await response.Content.ReadAsStringAsync();

            return JObject.Parse(jsonstring);
        }

        public static async Task<JObject> SendGetRequest(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            string jsonstring = await response.Content.ReadAsStringAsync();

            return JObject.Parse(jsonstring);
        }

        public static HttpClient GetClient() { return client; }
        public static Employee GetEmployee() { return employee; }




    }
}
