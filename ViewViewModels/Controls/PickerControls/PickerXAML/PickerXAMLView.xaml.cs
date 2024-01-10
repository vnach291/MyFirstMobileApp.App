namespace MyFirstMobileApp.ViewViewModels.Controls.PickerControls.PickerXAML;

public partial class PickerXAMLView : ContentPage
{
	public PickerXAMLView()
	{
		InitializeComponent();
		BindingContext = new PickerXAMLViewModel(); 

	}
}