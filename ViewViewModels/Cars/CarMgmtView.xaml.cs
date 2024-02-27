using MyFirstMobileApp.Models.Entities;

namespace MyFirstMobileApp.ViewViewModels.Cars;

public partial class CarMgmtView : ContentPage
{
	public CarMgmtView(Car car)
	{
		InitializeComponent();
        BindingContext = new CarMgmtViewModel(car);
    }
}