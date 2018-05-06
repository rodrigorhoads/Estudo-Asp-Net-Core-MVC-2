using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient cliente = new HttpClient();

            var httpTask = await cliente.GetAsync("http://apress.com");

            return httpTask.Content.Headers.ContentLength;
       
        }
    }
}
