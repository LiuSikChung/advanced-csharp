using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsynchronousProgramming.Modern
{
    public class WebClient
    {
        public static async Task<string> GetHtml(Uri webPage)
        {
            using (var client = new HttpClient())
            {
                var data = await client.GetAsync(webPage);

                return await data.Content.ReadAsStringAsync();
            }
        }
    }
}
