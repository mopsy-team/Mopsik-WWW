using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace mopsik_www.Models
{
    public class ApiManager
    {

        readonly string uri = "http://reach.mimuw.edu.pl:8008/mops/";
        public AppDataStorage AppDataStorage { get; set; }

        public ApiManager(AppDataStorage appDataStorage)
        {
            AppDataStorage = appDataStorage;
        }

        private async Task<List<Mop>> GetApiData()
        {
            if (AppDataStorage.DoNextApiCall())
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    List<Mop> mops = Mop.DeserializeMops(await httpClient.GetStringAsync(uri));
                    AppDataStorage.Mops = mops;
                    AppDataStorage.LastApiCall = DateTime.Now;
                    return mops;
                }
            }
            else
            {
                return AppDataStorage.Mops;
            }
        }

        public async Task<List<Mop>> GetMopsAsync()
        {
            return await GetApiData();
        }

        public async Task<Mop> GetMopAsync(int id)
        {
            return (await GetApiData()).Find(m => (m.Id == id));
        }
    }
}
