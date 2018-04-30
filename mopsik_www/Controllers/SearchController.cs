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

        public async Task<ActionResult> Search2()
        {

            return View("Search",
                await apiManager.GetMopsAsync()
            );
        }

        public async Task<string> Search()
        {

            return await apiManager.GetMopsAsync();
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult SaveEmployee(Mop e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        return Content(e.FirstName + "|" + e.LastName + "|" + e.Salary);
                    }
                    else
                    {
                        return View("CreateEmployee");
                    }
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }
    }
}