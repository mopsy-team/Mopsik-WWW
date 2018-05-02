using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mopsik_www.Models;
using Newtonsoft.Json;

namespace mopsik_www.ViewModels
{
    public class DetailsViewModel
    {
        public MopViewModel MopView { get; set; }
        public FacilitiesConfig FacilitiesConfig { get; set; }
        public Dictionary<bool, string> IconColor = new Dictionary<bool, string>() { { true, "#3d6dcc" }, { false, "lightgray" } };
        public Dictionary<bool, string> TextColor = new Dictionary<bool, string>() { { true, "black" }, { false, "gray" } };
        public Dictionary<bool, string> AvailableColor = new Dictionary<bool, string>() { { true, "green" }, { false, "red" } };
        public Dictionary<bool, string> AvailableIcon = new Dictionary<bool, string>() { { true, "done" }, { false, "clear" } };

        public DetailsViewModel(Mop mop)
        {
            MopView = new MopViewModel(mop);
            FacilitiesConfig = new FacilitiesConfig();
        }
    }
}
