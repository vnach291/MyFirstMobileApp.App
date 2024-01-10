namespace MyFirstMobileApp.ViewViewModels.Controls.DatePickerControls.DatePickerVM;

public partial class DatePickerVMView : ContentPage
{
    public DatePickerVMView()
    {
        InitializeComponent();
        BindingContext = new DatePickerVMViewModel();
    }
}