using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mopsik_www.Models;

namespace mopsik_www.ViewModels
{
    public class MopViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Chainage { get; set; }
        public string Direction { get; set; }
        public string RoadNumber { get; set; }
        public string Town { get; set; }
        public Operator Operator { get; set; }
        public Facilities Facilities { get; set; }
        public Coordinates Coordinates { get; set; }
        public SpacesCount Available { get; set; }
        public SpacesCount Taken { get; set; }

        public MopViewModel(Mop m)
        {
            Id = m.Id;
            Title = m.Title;
            Chainage = m.Chainage;
            Direction = m.Direction;
            RoadNumber = m.RoadNumber;
            Town = m.Town;
            Operator = m.Operator;
            Facilities = m.Facilities;
            Coordinates = m.Coordinates;
            Available = m.Available;
            Taken = m.Taken;
        }
    }
}
