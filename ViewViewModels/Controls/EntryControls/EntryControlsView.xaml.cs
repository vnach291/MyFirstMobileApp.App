namespace MyFirstMobileApp.ViewViewModels.Controls.EntryControls;

public partial class EntryControlsView : ContentPage
{
	public EntryControlsView(string entryText)
	{
		InitializeComponent();
		BindingContext = new EntryControlsViewModel(entryText);
	}
}