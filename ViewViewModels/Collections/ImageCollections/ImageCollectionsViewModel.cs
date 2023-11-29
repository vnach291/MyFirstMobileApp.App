
using MyFirstMobileApp.Models.CollectionsModels;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Collections.ImageCollections
{
    public class ImageCollectionsViewModel : BaseViewModel
    {
        public ObservableCollection<ElementDiagrams> ElementsCollection { get; }

        private List<ElementDiagrams> _elements; 

        public ImageCollectionsViewModel()
        {
            Title = ImageCollectionsTitleLayouts.InnerPageTitle;
          

            // instantiate observable elementdiagrams collection

            ElementsCollection = new ObservableCollection<ElementDiagrams>();
            _elements = ElementDiagrams.GetSampleElementData();
            this.loadElements(); 
        }

        private void loadElements()
        {
            try
            {
                ElementsCollection.Clear(); 
                foreach(var e in _elements)
                {
                    ElementsCollection.Add(e);
                }
            }
            catch(Exception ex)
            {
                //Debug.WriteLine(ex);
            }
        }

    }
}
