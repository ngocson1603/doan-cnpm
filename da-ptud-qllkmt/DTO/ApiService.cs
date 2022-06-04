using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Web;

namespace DTO
{
    public class ApiService
    {
        public HttpClient Client { get; set; }
        public ApiService()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServiceUrl"].ToString());
        }
        public HttpResponseMessage GetResponse(string url)
        {
            return Client.GetAsync(url).Result;
        }
        public HttpResponseMessage GetResponse(string url, object model)
        {
            return Client.PostAsJsonAsync(url, model).Result;
        }
        public HttpResponseMessage PutResponse(string url, object model)
        {
            return Client.PutAsJsonAsync(url, model).Result;
        }
        public HttpResponseMessage PostResponse(string url, object model)
        {
            return Client.PostAsJsonAsync(url, model).Result;
        }
        public HttpResponseMessage DeleteResponse(string url)
        {
            return Client.DeleteAsync(url).Result;//>>>
        }
    }
}
