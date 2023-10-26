using MyFirstMobileApp.ViewViewModels.AppImages.AppImagesContents;

namespace MyFirstMobileApp.ViewViewModels.AppImages.ActivityIndicator;

public partial class ActivityIndicatorView : ContentPage
{
	public ActivityIndicatorView()
	{
		InitializeComponent();
		BindingContext = new ActivityIndicatorViewModel();
	}
}