namespace MyFirstMobileApp.ViewViewModels.Controls.EntryControls;

public partial class EntryResultsView : ContentPage
{
	public EntryResultsView(string entryText)
	{
		InitializeComponent();
		BindingContext =  new EntryResultsViewModel(entryText);
	}
}