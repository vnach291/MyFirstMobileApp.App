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
        public ObservableCollection<Car> carCollection
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

            //Initialize the vacation collection
            CarCollection = new ObservableCollection<Car>();

            //Trigger an asynchronous refresh of the vacation list data
            Task.Run(async () => await RefreshCarListData());

            _ = RefreshCarListData();
        }


    }
}
