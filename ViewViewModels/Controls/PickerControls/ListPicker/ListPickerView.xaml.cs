namespace MyFirstMobileApp.ViewViewModels.Controls.PickerControls.ListPicker;

public partial class ListPickerView : ContentPage
{
	public ListPickerView()
	{
		InitializeComponent();
		BindingContext = new ListPickerViewModel(); 

	}
}