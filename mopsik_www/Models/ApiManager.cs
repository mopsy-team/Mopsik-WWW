using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace mopsik_www.Models
{
    public class ApiManager
    {

        readonly string uri = "http://reach.mimuw.edu.pl:8008/mops/";

        public async Task<string> GetMopsAsync()
        {

            using (HttpClient httpClient = new HttpClient())
            {
                /*
                return JsonConvert.DeserializeObject<List<Mop>>(
                    await httpClient.GetStringAsync(uri)
                );
                */
                return await httpClient.GetStringAsync(uri);
              
            }
        }
    }
}
