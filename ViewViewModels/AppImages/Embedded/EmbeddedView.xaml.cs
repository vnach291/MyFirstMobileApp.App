using MyFirstMobileApp.ViewViewModels.AppImages.AppImagesContents;

namespace MyFirstMobileApp.ViewViewModels.AppImages.Embedded;

public partial class EmbeddedView : ContentPage
{
	public EmbeddedView()
	{
		InitializeComponent();
        BindingContext = new EmbeddedViewModel();
    }
}