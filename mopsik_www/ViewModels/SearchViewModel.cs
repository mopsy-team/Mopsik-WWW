using mopsik_www.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace mopsik_www.ViewModels
{
    public class SearchViewModel
    {
        public MopListViewModel MopsView { get; set; }
        public string SearchPhrase { get; set; }
        public Dictionary<string, bool> Facilities { get; set; }
        public FacilitiesConfig FacilitiesConfig { get; set; }
        public string FiltersJSON { get; set; }
        public string ResultCount { get; set; }

        static public Dictionary<string, bool> CreateFacilities()
        {
            return new Dictionary<string, bool>()
            {
                { "monitoring", false},
                { "garage", false },
                { "toilets", false },
                { "petrol_station", false },
                { "dangerous_cargo_places", false },
                { "sleeping_places", false },
                { "restaurant", false },
                { "car_wash", false },
                { "security", false },
                { "lighting", false },
            };
        }


        private string GetResultCount(int count)
        {
            string app;
            if(count == 1)
            {
                app = "wynik";
            }
            else if((count % 10) > 1 && (count % 10) < 5 && (count < 10 || count > 20))
            {
                app = "wyniki";
            }
            else
            {
                app = "wyników";
            }
            return String.Format("{0} {1}", count, app);
        }

        public SearchViewModel(MopListViewModel mopsView, string searchPhrase)
        {
            MopsView = mopsView;
            SearchPhrase = searchPhrase;
            Facilities = CreateFacilities();
            FacilitiesConfig = new FacilitiesConfig();
            FiltersJSON = "[]";
            ResultCount = GetResultCount(mopsView.Mops.Count());
        }

        public SearchViewModel(MopListViewModel mopsView, string searchPhrase, Dictionary<string, bool> facilities, string[] filters)
        {
            MopsView = mopsView;
            SearchPhrase = searchPhrase;
            Facilities = facilities;
            FacilitiesConfig = new FacilitiesConfig();
            FiltersJSON = JsonConvert.SerializeObject(filters);
            ResultCount = GetResultCount(mopsView.Mops.Count());
        }

        public SearchViewModel(MopListViewModel mopsView, string searchPhrase, Dictionary<string, bool> facilities, string filtersJSON)
        {
            MopsView = mopsView;
            SearchPhrase = searchPhrase;
            Facilities = facilities;
            FacilitiesConfig = new FacilitiesConfig();
            FiltersJSON = filtersJSON;
            ResultCount = GetResultCount(mopsView.Mops.Count());
        }
    }
}
