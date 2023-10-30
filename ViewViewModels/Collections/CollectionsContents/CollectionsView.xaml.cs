using MyFirstMobileApp.ViewViewModels.AppImages.AppImagesContents;

namespace MyFirstMobileApp.ViewViewModels.Collections.CollectionsContents;

public partial class CollectionsView : ContentPage
{
	public CollectionsView()
	{
		InitializeComponent();
        BindingContext = new CollectionsViewModel();
    }
}