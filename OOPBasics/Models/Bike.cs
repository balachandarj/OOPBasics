using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.Models
{
    internal class Bike
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int TopSpeed { get; set; }

        public string EngineType { get; set; }

        public int YearMake { get; set; }

        public int NumberOfCylinder { get; set; }

        public bool IsABS { get; set; }


        public bool Start()
        {
            // Start the bike

            if (IsFueal())
            {
                // Bike started
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Stop()
        {
            if (IsNeutral())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsNeutral()
        {
            return true;
        }

        private bool IsFueal()
        {
            return false;
        }
    }
}

