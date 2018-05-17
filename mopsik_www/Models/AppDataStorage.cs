using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mopsik_www.Models
{
    public class AppDataStorage
    {
        public List<Mop> Mops { get; set; }
        public DateTime LastApiCall { get; set; }
    
        public bool DoNextApiCall()
        {
            return DateTime.Now.Subtract(LastApiCall).TotalSeconds > 120;
        }
    }
}
