namespace MyFirstMobileApp.ViewViewModels.AppImages.URI;

public partial class URIView : ContentPage
{
	public URIView()
	{
		InitializeComponent();
		BindingContext = new URIViewModel(); 
	}
}