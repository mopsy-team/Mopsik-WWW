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
        public string VehicleType { get; set; }
        public string CarButtonClass { get; set; }
        public string TruckButtonClass { get; set; }
        public string BusButtonClass { get; set; }

        private string GetButtonClass(bool cond)
        {
            return (cond) ? "mdl-button mdl-js-button mdl-button--fab mdl-button--mini-fab mdl-button--colored" : "mdl-button mdl-js-button mdl-button--fab mdl-button--mini-fab";
        }

        public MapViewModel(MopListViewModel mopsView, string vehicleType)
        {
            MopsView = mopsView;
            VehicleType = vehicleType;
            CarButtonClass = GetButtonClass(vehicleType == "car");
            TruckButtonClass = GetButtonClass(vehicleType == "truck");
            BusButtonClass = GetButtonClass(vehicleType == "bus");
        }

    }
}
