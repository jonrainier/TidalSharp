using System.Net;
using Newtonsoft.Json;
using TidalSharp.Models;

namespace TidalSharp.Controllers
{
    public class TidalController
    {
        public TidalController()
        {
            Tidal = new Tidal(this);
        }

        public Tidal Tidal { get; set; }

        public enum RequestType
        {
            Get,
            Post
        }

        public void ApiRequest<T>(string requestUrl, RequestType requestType = RequestType.Get, string requestParameters = "")
        {
            const string prefix = "https://api.tidalhifi.com/v1";

            using (var client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                string requestData;

                if (requestType == RequestType.Get)
                    requestData = client.DownloadString(prefix + requestUrl);
                else
                {
                    client.Headers.Add("Host", "api.tidalhifi.com");
                    client.Headers.Add("Accept", "*/*");
                    client.Headers.Add("Accept-Language", "en-US,en;q=0.5");
                    client.Headers.Add("Accept-Encoding", "gzip, deflate, br");
                    client.Headers.Add("Referer", "http://listen.tidal.com/login");
                    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                    client.Headers.Add("X-Tidal-Token", "wdgaB1CilGA-S_s2");
                    client.Headers.Add("Origin", "https://listen.tidal.com");

                    requestData = client.UploadString(prefix + requestUrl, requestParameters);
                }

                var formattedData = JsonConvert.DeserializeObject<T>(requestData);
                Tidal.GetType().GetProperty(typeof (T).Name).SetValue(Tidal, formattedData);
            }
        }
    }
}
