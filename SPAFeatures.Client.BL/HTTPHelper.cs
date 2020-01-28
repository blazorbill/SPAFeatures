using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SPAFeatures.Client.BL
{
    public static class HTTPHelper
    {
        public static HttpClient client = new HttpClient();
        public async static Task<T> HttpGet<T>(string baseUrl, string uri)
        {

            var request = new HttpRequestMessage(HttpMethod.Get,
                $"{baseUrl}/{uri}");
            request.Headers.Add("Accept", "application/json");

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var myName = JsonConvert.DeserializeObject<T>(json);
                return myName;
            }
            else
            {
                throw new System.Exception();
            }
        }
        public async static Task<bool> HttpPost<T>(string baseUrl, string uri, T data)
        {
            var request = new HttpRequestMessage(HttpMethod.Post,
                $"{baseUrl}/{uri}");
            request.Headers.Add("Accept", "application/json");
            var json = JsonConvert.SerializeObject(data);
            request.Content = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new System.Exception();
            }
        }
    }
}