namespace MyFirstMobileApp.ViewViewModels.Controls.PickerControls.PickerResults;

public partial class PickerResultsView : ContentPage
{
    public PickerResultsView(string value, ImageSource image)
    {
        InitializeComponent();
        BindingContext = new PickerResultsViewModel(value, image);
    }
}