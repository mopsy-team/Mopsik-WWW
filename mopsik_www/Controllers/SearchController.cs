using Microsoft.AspNetCore.Mvc;
using mopsik_www.Models;
using mopsik_www.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace mopsik_www.Controllers
{
    public class SearchController : Controller
    {
        private ApiManager apiManager = new ApiManager();

        private bool SearchConditionWord(MopViewModel mop, string searchPhrase)
        {
            return (mop.Title.ToLower().Contains(searchPhrase)) || (mop.RoadNumber.ToLower().Contains(searchPhrase)) ||
                (mop.Direction.ToLower().Contains(searchPhrase)) || (mop.Town.ToLower().Contains(searchPhrase));
        }

        private bool SearchCondition(MopViewModel mop, string searchPhrase)
        {
            if (searchPhrase == null)
            {
                return true;
            }
            foreach(string word in searchPhrase.Split())
            {
                if(! SearchConditionWord(mop, word))
                {
                    return false;
                }
            }
            return true;
        }

        private bool FilterCondition(MopViewModel mop, string[] filters)
        {
            foreach(string filter in filters)
            {
                if (!mop.Facilities[filter])
                {
                    return false;
                }
            }
            return true;
        }

        private List<MopViewModel> RunSearchAndFilter(List<MopViewModel> mops, string searchPhrase, string[] filters)
        {
            return mops.Where(mop => (SearchCondition(mop, searchPhrase) && FilterCondition(mop, filters))).ToList();
        }

        private Dictionary<string, bool> GetFacilities(string[] filters)
        {
            Dictionary<string, bool> facilities = SearchViewModel.CreateFacilities();
            foreach (string icon in filters)
            {
                facilities[icon] = true;
            }
            return facilities;
        }

        private async Task<MopListViewModel> GetMopListViewModel(string searchPhrase, string[] filters)
        {
            List<Mop> parsed = await apiManager.GetMopsAsync();
            MopListViewModel mopsView = new MopListViewModel(parsed);
            mopsView.Mops = RunSearchAndFilter(mopsView.Mops, searchPhrase?.ToLower(), filters);
            return mopsView;
        }

        public async Task<ActionResult> Index()
        {
            List<Mop> parsed = await apiManager.GetMopsAsync();
            MopListViewModel mopsView = new MopListViewModel(parsed);
            return View("Search", new SearchViewModel(mopsView, null));
        }

        public async Task<ActionResult> Search(string searchPhrase, string filtersJSON)
        {
            string[] filters = JsonConvert.DeserializeObject<string[]>(filtersJSON);
            Dictionary<string, bool> facilities = GetFacilities(filters);
            MopListViewModel mopsView = await GetMopListViewModel(searchPhrase, filters);
            return View("Search", new SearchViewModel(mopsView, searchPhrase, facilities, filtersJSON));
        }

        public async Task<ActionResult> Filter(string searchPhrase)
        {
            string[] filters = Request.Form["checkedIcon[]"];
            Dictionary<string, bool> facilities = GetFacilities(filters);
            MopListViewModel mopsView = await GetMopListViewModel(searchPhrase, filters);
            return View("Search", new SearchViewModel(mopsView, searchPhrase, facilities, filters));
        }


        public async Task<ActionResult> ClearSearch(string filtersJSON)
        {
            string searchPhrase = null;
            string[] filters = JsonConvert.DeserializeObject<string[]>(filtersJSON);
            Dictionary<string, bool> facilities = GetFacilities(filters);
            MopListViewModel mopsView = await GetMopListViewModel(searchPhrase, filters);
            return View("Search", new SearchViewModel(mopsView, searchPhrase, facilities, filtersJSON));
        }

        public async Task<ActionResult> ClearFilter(string searchPhrase)
        {
            string filtersJSON = "[]";
            string[] filters = JsonConvert.DeserializeObject<string[]>(filtersJSON);
            Dictionary<string, bool> facilities = GetFacilities(filters);
            MopListViewModel mopsView = await GetMopListViewModel(searchPhrase, filters);
            return View("Search", new SearchViewModel(mopsView, searchPhrase, facilities, filtersJSON));
        }





    }
}