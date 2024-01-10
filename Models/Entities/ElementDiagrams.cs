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
            var elements = new List<ElementDiagrams>
            {
                // Create PeriodicTableDiagram objects with saimple data
                new ElementDiagrams("Hydrogen", ImageSource.FromFile("Images/Elements/hydrogen.png"), "H"),
                new ElementDiagrams("Helium", ImageSource.FromFile("Images/Elements/helium.png"), "He"),
                new ElementDiagrams("Lithium", ImageSource.FromFile("Images/Elements/lithium.png"), "L"),
                new ElementDiagrams("Beryllium", ImageSource.FromFile("Images/Elements/beryllium.png"), "Be"),
                new ElementDiagrams("Boron", ImageSource.FromFile("Images/Elements/boron.png"), "B"),
                new ElementDiagrams("Carbon", ImageSource.FromFile("Images/Elements/carbon.png"), "C"),
                new ElementDiagrams("Nitrogen", ImageSource.FromFile("Images/Elements/nitrogen.png"), "N"),
                new ElementDiagrams("Oxygen", ImageSource.FromFile("Images/Elements/oxygen.png"), "O")
            };

            return elements; 
        }

        public static List<string> GetElementNames()
        {

            // get the sample element data
            var sampleData = GetSampleElementData();

            // select and convery element names into a list
            return sampleData.Select(info => info.ElementName).ToList(); 
        }



    }
}
