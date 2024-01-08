namespace MyFirstMobileApp.ViewViewModels.Controls.PickerControls.PickerVM;

public partial class PickerVMView : ContentPage
{
	public PickerVMView()
	{
		InitializeComponent();
		BindingContext = new PickerVMViewModel(); 
	}
}