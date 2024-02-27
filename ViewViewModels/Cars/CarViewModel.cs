using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.DataAccess;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Cars
{
    // ViewModel for managing Car data
    public class CarViewModel : BaseViewModel
    {
        private readonly SQLiteImplementation _sqliteService = new SQLiteImplementation();

        //Collection to hold car data for the UI
        private ObservableCollection<Car> _carCollection;

        //Property to expose the car collection to the UI
        public ObservableCollection<Car> CarCollection
        {
            get { return _carCollection; }
            set
            {
                _carCollection = value;
                OnPropertyChanged();
                //Debug.WriteLine($"carCollection Count: {_carCollection?.Count}");
            }
        }

        //Constructor to initialize the ViewModel
        public CarViewModel()
        {
            Title = TitleCars.TitleCar;

            //Initialize the car collection
            CarCollection = new ObservableCollection<Car>();

            //Trigger an asynchronous refresh of the vacation list data
            Task.Run(async () => await RefreshCarListData());

            _ = RefreshCarListData();
        }
        public async Task RefreshCarListData()
        {
            // Retrieve vacation data from the SQLite database
            var car = await _sqliteService.GetCar();

            // Update the ViewModel's vacation collection with the new data
            CarCollection = new ObservableCollection<Car>(car);
        }

        //Command to navigate to the CarMgmtView and handle Adds
        public Command AddCommand
        {
            get
            {
                return new Command<Car>((Car car) =>
                {
                    //Unsubscribe from events - precautionary step to ensure that there are no existing subscriptions for the specified events
                    MessagingCenter.Unsubscribe<Car>(this, "AddCar");

                    //Navigate to the CarAddView, passing a car if available
                    Application.Current.MainPage.Navigation.PushAsync(new CarMgmtView(car));

                    //Subscribe to a MessagingCenter event for refreshing data when a new car is added
                    MessagingCenter.Subscribe<Car>(this, "AddCar", async (data) =>
                    {
                        //Refresh the car list data asynchronously
                        await RefreshCarListData();
                        //Unsubscribe from the MessagingCenter event after refreshing data
                        MessagingCenter.Unsubscribe<Car>(this, "AddCar");
                    });
                });
            }
        }

        //Command to navigate to the CarMgmtView and handle Updates
        public Command UpdateCommand
        {
            get
            {
                return new Command<Car>((Car car) =>
                {
                    //Unsubscribe from events - precautionary step to ensure that there are no existing subscriptions for the specified events
                    MessagingCenter.Unsubscribe<Car>(this, "UpdateCar");

                    //Navigate to the VacationAddView, passing a car if available
                    Application.Current.MainPage.Navigation.PushAsync(new CarMgmtView(car));

                    //Subscribe to a MessagingCenter event for refreshing data when a new car is updated
                    MessagingCenter.Subscribe<Car>(this, "UpdateCar", async (data) =>
                    {
                        // Refresh the car list data asynchronously
                        await RefreshCarListData();
                        // Unsubscribe from the MessagingCenter event after refreshing data
                        MessagingCenter.Unsubscribe<Car>(this, "UpdateCar");
                    });
                });
            }
        }

        //Command to delete a vacation and update the collection
        public Command<Car> DeleteCommand
        {
            get
            {
                return new Command<Car>((Car car) =>
                {
                    //Delete the vacation from the SQLite database
                    _ = _sqliteService.DeleteCar(car.Id);

                    //Remove the vacation from the ViewModel's collection
                    CarCollection.Remove(car);
                });
            }
        }

    }
}

/*
                     //Subscribe to a MessagingCenter event for refreshing data when a new vacation is added
                    //MessagingCenter.Subscribe<VacationAddViewModel, Vacation>(this, "AddVacation", async (sender, addedVacation) =>
                    MessagingCenter.Subscribe<Vacation>(this, "AddVacation", async (data) =>
                    {
                        //Refresh the vacation list data asynchronously
                        await RefreshVacationListData();

                        //Unsubscribe from the MessagingCenter event after refreshing data
                        MessagingCenter.Unsubscribe<Vacation>(this, "AddVacation");
                        //MessagingCenter.Unsubscribe<VacationAddViewModel, Vacation>(this, "AddVacation");
                    });
*/