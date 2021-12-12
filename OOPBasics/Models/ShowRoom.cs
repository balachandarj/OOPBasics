using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.Models
{
    internal class ShowRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Bike> BikeList { get; set; }


        public bool FindBike(string bikeName)
        {
            var bike= BikeList.FirstOrDefault(o => o.Name == bikeName);
            if(bike == null)
                return false;
            return true;
        }


    }
}
