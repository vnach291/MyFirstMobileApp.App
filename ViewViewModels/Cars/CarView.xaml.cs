namespace MyFirstMobileApp.ViewViewModels.Cars;

public partial class CarView : ContentPage
{
	public CarView()
	{
		InitializeComponent();
		BindingContext = new CarViewModel();
	}
}