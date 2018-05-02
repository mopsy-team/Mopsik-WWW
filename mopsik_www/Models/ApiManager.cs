using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace mopsik_www.Models
{
    public class ApiManager
    {

        readonly string uri = "http://reach.mimuw.edu.pl:8008/mops/";

        public async Task<List<Mop>> GetMopsAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return Mop.DeserializeMops(await httpClient.GetStringAsync(uri));
            }
        }

        public async Task<Mop> GetMopAsync(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return Mop.DeserializeMop(await httpClient.GetStringAsync(uri), id);
            }
        }
    }
}
