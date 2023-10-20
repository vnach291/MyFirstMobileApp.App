namespace MyFirstMobileApp.ViewViewModels.AppImages.AppImagesContents;

public partial class AppImagesView : ContentPage
{
	public AppImagesView()
	{
		InitializeComponent();
		BindingContext = new AppImagesViewModel();
	}
}