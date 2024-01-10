namespace MyFirstMobileApp.ViewViewModels.Controls.PickerControls;

public partial class PickerControlsView : ContentPage
{
	public PickerControlsView()
	{
		InitializeComponent();
		BindingContext = new PickerControlsViewModel();
	}
}