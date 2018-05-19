using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mopsik_www.Models;
using mopsik_www.ViewModels;

namespace mopsik_www.Controllers
{
    public class MapController : Controller
    {
        private ApiManager ApiManager { get; set; }

        public MapController(AppDataStorage appDataStorage)
        {
            ApiManager = new ApiManager(appDataStorage);
        }

        public async Task<ActionResult> Index()
        {
            List<Mop> parsed = await ApiManager.GetMopsAsync();
            MopListViewModel mopsView = new MopListViewModel(parsed);
            return View("Map", new MapViewModel(mopsView, "car"));
        }
        
        public async Task<ActionResult> SetVehicleType(string vehicleType)
        {
            List<Mop> parsed = await ApiManager.GetMopsAsync();
            MopListViewModel mopsView = new MopListViewModel(parsed);
            return View("Map", new MapViewModel(mopsView, vehicleType));
        }
    }
}
