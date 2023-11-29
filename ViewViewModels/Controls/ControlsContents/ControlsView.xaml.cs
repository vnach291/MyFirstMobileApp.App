using MyFirstMobileApp.ViewViewModels.Collections.IconCollections;

namespace MyFirstMobileApp.ViewViewModels.Controls.ControlsContents;

public partial class ControlsView : ContentPage
{
	public ControlsView()
	{
		InitializeComponent();
        BindingContext = new ControlsViewModel();
    }
}