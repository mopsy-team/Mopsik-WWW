using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mopsik_www.Models;

namespace mopsik_www.ViewModels
{
    public class MopListViewModel
    {
        public List<MopViewModel> Mops { get; set; }

        public MopListViewModel(List<Mop> mops)
        {
            Mops = (from mop in mops select new MopViewModel(mop)).ToList();
        }

        public MopListViewModel()
        {
            Mops = new List<MopViewModel>();
        }

        public bool IsEmpty()
        {
            return Mops.Count == 0;
        }
    }
}
