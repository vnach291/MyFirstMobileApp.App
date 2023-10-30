using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.Entities
{
    public class PeriodicElements
    {
        public string NameofElement { get; set; }

        public PeriodicElements()
        {

        }

        public PeriodicElements(string element)
        {
            NameofElement = element;
        }

        public static List<PeriodicElements> GetElements()
        {
            return new List<PeriodicElements>
            {
                new PeriodicElements("Hydrogen"),
                new PeriodicElements("Helium"),
                new PeriodicElements("Lithium"),
                new PeriodicElements("Beryllium"),
                new PeriodicElements("Boron"),
                new PeriodicElements("Carbon"),
                new PeriodicElements("Nitrogen"),
                new PeriodicElements("Oxygen"),
            };
        }
    }
}
