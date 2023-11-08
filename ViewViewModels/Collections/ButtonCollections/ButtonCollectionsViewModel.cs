using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.CollectionsModels;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;
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
            await Application.Current.MainPage.Navigation.PushAsync(new AddCollectionView());

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
                //Add the new elment data to the collection
                ElementCollection.Add(data);

                //Unsubscribe from the messaging event
                MessagingCenter.Unsubscribe<PeriodicElements>(this, "AddElements");
            });
        });

        //Command to update a movie
        public ICommand UpdateCommand => new Command<PeriodicElements>(async element =>
        {
            //Get the index of the selected movie in the collection
            var index = ElementCollection.IndexOf(element);

            //Navigate to the EditCollectionView to edit the selected movie when the Update Button is Clicked
            await Application.Current.MainPage.Navigation.PushAsync(new EditCollectionView(element));

            //****************************************************************************************
            // A messaging event is a way for different parts of your app to communicate.
            // It's like a message sent from one part to another to share data or trigger actions.
            // MessagingCenter helps subscribe to and send these events.
            // In this code, when you update a movie in EditCollectionView, it sends an "UpdateMovies" event.
            // UpdateableCollectionWButtonsViewModel listens for this event and updates the movie list.
            //****************************************************************************************
            //Subscribe to the "UpdateMovies" messaging event to receive updated data from EditCollectionView            
            MessagingCenter.Subscribe<PeriodicElements>(this, "UpdateElements", updatedElement =>
            {
                //Update the movie in the collection with the edited data
                ElementCollection[index] = updatedElement;
            });
        });

        //Command to delete a movie
        public ICommand DeleteCommand => new Command<PeriodicElements>(element =>
        {
            //Remove the selected movie from the collection
            ElementCollection.Remove(element);
        });
        #pragma warning restore CA1416 // Validate platform compatibility
    }
}
