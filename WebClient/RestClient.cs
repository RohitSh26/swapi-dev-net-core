using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace swapi_dev_net_core.WebClient
{
    public class RestClient
    {
        // create a HTTP Client make get request, make an asyncronous call
        public static async Task<T> GetClient<T>(string url, Func<string, T> callback)
        {
            try
            {
                using(var client = new HttpClient())
                {
                    // make an asyncronous call, get response body
                    using(var response = await client.GetAsync(url))
                    {
                        // make sure that response code is success
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();

                        // check if we get non null response body
                        if(body == null)
                        {
                            // return the "default" or "empty" value 
                            return default;
                        }
                        else 
                        {
                            return callback(body);
                        }
                    }
                }
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                // return the "default" or "empty" value 
                return default;
            }
        }
    }
}