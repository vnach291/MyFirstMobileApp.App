using MyFirstMobileApp.ViewViewModels.Collections.ButtonCollections;

namespace MyFirstMobileApp.ViewViewModels.Collections.IconCollections;

public partial class IconCollectionsView : ContentPage
{
	public IconCollectionsView()
	{
		InitializeComponent();
        BindingContext = new IconCollectionsViewModel();
    }
}