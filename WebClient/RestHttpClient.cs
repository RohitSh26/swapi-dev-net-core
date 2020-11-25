using System;
using System.Threading.Tasks;
using System.Net.Http;
namespace swapi_dev_net_core.WebClient
{
    // simplified version on HttpClient
    public static class RestHttpClient
    {
        // create an asyncronus http client
        public static async Task<T> GetClient<T>(string url, Func<string, T> callback)
        {
            // create an HttpClient
            try
            {
                using(var client = new HttpClient())
                {
                    // simple approach 
                    var body = await client.GetStringAsync(url);

                    if(body == null)
                    {
                        return default;
                    }
                    else
                    {
                        return callback(body);
                    }                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                return default;
            }
        }
    }
}