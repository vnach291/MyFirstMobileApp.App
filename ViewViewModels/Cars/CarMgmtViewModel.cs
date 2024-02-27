using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.DataAccess;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Cars
{
    public class CarMgmtViewModel : BaseViewModel
    {
        //Properties to bind to the UI
        public List<Car> CarCollection { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }
        public int Id { get; set; }

        //Text for the button based on whether it's an update or save operation
        public string ButtonText { get; set; }

        //Create an instance of the SQLiteImplementation class to handle SQLite database operations,
        //and assign it to the private readonly field _sqliteService for use throughout the class.
        //readonly variable ensures it can only be assigned a value at the time of declaration or in the constructor
        private readonly SQLiteImplementation _sqliteService = new SQLiteImplementation();

        //Constructor to initialize the ViewModel with existing vacation details if provided
        public CarMgmtViewModel(Car car)
        {
            //Initialize the collection
            CarCollection = new List<Car>();

            if (car != null)
            {
                Title = TitleCars.TitleUpdateCar;

                //If car exists, populate ViewModel properties
                CarCollection.Add(car);
                Id = car.Id;
                Brand = car.Brand;
                Color = car.Color;
                Miles = car.Miles;

                ButtonText = "Update";
            }
            else
            {
                Title = TitleCars.TitleAddCar;

                //If no car provided, initialize a new one and set button text to "Save"
                CarCollection = new List<Car>();

                ButtonText = "Save";
            }
        }

        //Command for saving or updating vacation details
        public Command<Car> PerformSave
        {
            get
            {
                return new Command<Car>(async (Car car) =>
                {
                    try
                    {
                        //Check for required data before save or update
                        if (string.IsNullOrEmpty(Brand) || string.IsNullOrEmpty(Color))
                        {
                            await Application.Current.MainPage.DisplayAlert("Message", "Brand and Color are required.", "Ok");
                            return;
                        }

                        if (ButtonText == "Save")
                        {
                            //Creating a new Vacation instance with ViewModel properties
                            car = new Car
                            {
                                Id = Id,
                                Brand = Brand,
                                Color = Color,
                                Miles = Miles
                            };

                            //Save the new vacation
                            string result = await _sqliteService.SaveCar(car);

                            if (result == string.Empty)
                            {
                                //Send a message to notify about the addition of a new car
                                MessagingCenter.Send<Car>(car, "AddCar");

                                if (Application.Current.MainPage != null)
                                {
                                    await Application.Current.MainPage.Navigation.PopAsync();
                                }
                            }
                            else
                            {
                                await Application.Current.MainPage.DisplayAlert("Message", result, "Ok");
                            }
                        }
                        else
                        {
                            //Creating a new Vacation instance with ViewModel properties for an update
                            car = new Car
                            {
                                Id = Id,
                                Brand = Brand,
                                Color = Color,
                                Miles = Miles
                            };

                            //Update the existing vacation details
                            bool result = await _sqliteService.UpdateCar(car);

                            if (result)
                            {
                                //Send a message to notify about the update of the vacation
                                MessagingCenter.Send<Car>(car, "UpdateCar");
                                await Application.Current.MainPage.Navigation.PopAsync();
                            }
                            else
                            {
                                await Application.Current.MainPage.DisplayAlert("Message", "Data Failed To Update", "Ok");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
                    }
                });
            }
        }


    }
}
