using MyFirstMobileApp.Models.CollectionsModels;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Collections.NormalCollections
{
    public class NormalCollectionsViewModel : BaseViewModel
    {
        // ViewModel: Private fields
        private List<PeriodicElements> _periodicelements;

        // ViewModel: Observable collection bound to the View
        // We use ObservableCollection to automatically update the View when the collection changes.
        public ObservableCollection<PeriodicElements> NormalCollection { get; }

        public NormalCollectionsViewModel()
        {
            // ViewModel: Setting the page title for the View
            Title = NormalCollectionsTitleLayouts.InnerPageTitle;

            // ViewModel: Initialize the ObservableCollection
            NormalCollection = new ObservableCollection<PeriodicElements>();

            _periodicelements = PeriodicElements.GetElements();
            this.LoadElements();
        }
        private void LoadElements()
        {
            try
            {
                // Clear the collection in the ViewModel
                NormalCollection.Clear();

                // Loop through all the movies in the ViewModel collection
                foreach (var p in _periodicelements)
                {
                    // Add the NameofMovie property of the individual movie to the ViewModel collection
                    NormalCollection.Add(new PeriodicElements { NameofElement = p.NameofElement });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    }
}
