using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mopsik_www.Models;
using mopsik_www.ViewModels;

namespace mopsik_www.Controllers
{
    public class DetailsController : Controller
    {
        private ApiManager ApiManager { get; set; }

        public DetailsController(AppDataStorage appDataStorage)
        {
            ApiManager = new ApiManager(appDataStorage);
        }

        private async Task<MopViewModel> GetMopViewModel(int id)
        {
            Mop parsed = await ApiManager.GetMopAsync(id);
            MopViewModel mopView = new MopViewModel(parsed);
            return mopView;
        }

        public async Task<ActionResult> Details(int id)
        {
            Mop parsed = await ApiManager.GetMopAsync(id);
            return View("Details", new DetailsViewModel(parsed));
        }
       

    }
}