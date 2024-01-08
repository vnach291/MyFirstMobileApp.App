using MyFirstMobileApp.ViewViewModels.Controls.PickerControls.PickerXAML;

namespace MyFirstMobileApp.ViewViewModels.Controls.PickerControls.PickerXAML;

public partial class ListPickerView : ContentPage
{
	public ListPickerView()
	{
		InitializeComponent();
		BindingContext = new PickerXAMLViewModel(); 

	}
}