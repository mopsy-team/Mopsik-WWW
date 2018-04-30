using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mopsik_www.Models;
using mopsik_www.ViewModels;

namespace mopsik_www.Controllers
{
    public class SearchController : Controller
    {
        private ApiManager apiManager = new ApiManager();

        public async Task<ActionResult> Search()
        {
            List<Mop> parsed = await apiManager.GetMopsAsync();

            return View("Search",
               new MopListViewModel(parsed)
            );
        }

  

    
    }
}