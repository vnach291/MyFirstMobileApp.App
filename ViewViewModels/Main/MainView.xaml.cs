using MyFirstMobileApp.ViewViewModels.StackLayoutContents;

namespace MyFirstMobileApp.ViewViewModels.Main;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
		
	}
}