using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.Entities
{
    public class ElementDiagrams
    {
        public string ElementName { get; set; } = string.Empty;
        public ImageSource ElementImage { get; set; } = null; 
        public string ElementAbbreviation { get; set; } = string.Empty; 
    
        public ElementDiagrams()
        {
            // default constructor
        }
    
        public ElementDiagrams(string elementName, ImageSource elementImage, string elementAbbreviation)
        {
            ElementName = elementName;
            ElementImage = elementImage;
            ElementAbbreviation = elementAbbreviation;
        }

        public static List<ElementDiagrams> GetSampleElementData()
        {
            var elements = new List<ElementDiagrams>();
            {
                // Create PeriodicTableDiagram objects with saimple data
                new ElementDiagrams("Hydrogen", ImageSource.FromFile("Images/Elements/hydrogen.png"), "H");


            };
        }


    }
}
