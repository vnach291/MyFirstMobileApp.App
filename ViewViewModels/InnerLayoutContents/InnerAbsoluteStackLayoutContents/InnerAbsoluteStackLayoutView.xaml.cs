namespace MyFirstMobileApp.ViewViewModels.InnerAbsoluteStackLayoutContents;

public partial class InnerAbsoluteStackLayoutView : ContentPage
{
	public InnerAbsoluteStackLayoutView()
	{
		InitializeComponent();
		BindingContext = new InnerAbsoluteStackLayoutViewModel(); 
	}
}