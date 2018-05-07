using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mopsik_www.Models;
using Newtonsoft.Json;

namespace mopsik_www.ViewModels
{
    public class MapViewModel
    {
        public MopListViewModel MopsView { get; set; }

        public MapViewModel(MopListViewModel mopsView)
        {
            MopsView = mopsView;
        }

    }
}
