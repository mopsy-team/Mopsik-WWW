using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mopsik_www.Models;
using mopsik_www.ViewModels;

namespace mopsik_www.Controllers
{
    public class MapController : Controller
    {
        private ApiManager apiManager = new ApiManager();

        public async Task<ActionResult> Index(int id)
        {
            List<Mop> parsed = await apiManager.GetMopsAsync();
            MopListViewModel mopsView = new MopListViewModel(parsed);
            return View("Map", new MapViewModel(mopsView));
        }
    }
}
