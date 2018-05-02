using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using mopsik_www.Models;
using mopsik_www.ViewModels;
using Newtonsoft.Json;
//using System.Web;

namespace mopsik_www.Controllers
{
    public class DetailsController : Controller
    {
        private ApiManager apiManager = new ApiManager();

        private async Task<MopViewModel> GetMopViewModel(int id)
        {
            Mop parsed = await apiManager.GetMopAsync(id);
            MopViewModel mopView = new MopViewModel(parsed);
            return mopView;
        }

        public async Task<ActionResult> Details(int id)
        {
            Mop parsed = await apiManager.GetMopAsync(id);
            return View("Details", new DetailsViewModel(parsed));
        }
       

    }
}