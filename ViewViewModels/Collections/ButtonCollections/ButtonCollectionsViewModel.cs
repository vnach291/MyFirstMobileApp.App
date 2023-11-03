using MyFirstMobileApp.Models;
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
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Collections.ButtonCollections
{
    public class ButtonCollectionsViewModel : BaseViewModel
    {
        public ObservableCollection<PeriodicElements> ElementCollection { get; set; }

        public ButtonCollectionsViewModel()
        {
            //Set the title for this view
            Title = ButtonCollectionsTitleLayouts.InnerPageTitle;

            //Create a new ObservableCollection to store movies
            ElementCollection = new ObservableCollection<PeriodicElements>();

            //Load movies from the data source
            LoadElements();
        }

        //Method to load elements from a data source
        private void LoadElements()
        {
            IsBusy = true;

            try
            {
                //Clear the existing collection
                ElementCollection.Clear();

                //Get a list of periodic elements and add them to the collection
                var periodicElements = PeriodicElements.GetElements();
                foreach (var element in periodicElements)
                {
                    ElementCollection.Add(element);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        #pragma warning disable CA1416 // Validate platform compatibility
        //Command to add a new element
        public ICommand AddCommand => new Command(async () =>
        {
            //Navigate to the AddCollectionView when the "Add" button is clicked

            // NEED TO CREATE THE ADD COLLECTION VIEW
            //await Application.Current.MainPage.Navigation.PushAsync(new AddCollectionView());

            //****************************************************************************************
            // A messaging event is a way for different parts of your app to communicate.
            // It's like a message sent from one part to another to share data or trigger actions.
            // MessagingCenter helps subscribe to and send these events.
            // In this code, when you add a movie in AddCollectionView, it sends an "AddMovies" event.
            // UpdateableCollectionWButtonsViewModel listens for this event and updates the movie list.
            //****************************************************************************************
            //Subscribe to the "AddMovies" messaging event to receive updated data from AddCollectionView            
            MessagingCenter.Subscribe<PeriodicElements>(this, "AddElements", async (data) =>
            {
                //Add the new movie data to the collection
                ElementCollection.Add(data);

                //Unsubscribe from the messaging event
                MessagingCenter.Unsubscribe<PeriodicElements>(this, "AddElements");
            });
        });


    }
}
