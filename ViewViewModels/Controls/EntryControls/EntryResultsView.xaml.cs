namespace MyFirstMobileApp.ViewViewModels.Controls.EntryControls;

public partial class EntryResultsView : ContentPage
{
	public EntryResultsView()
	{
		InitializeComponent();
		BindingContext =  new EntryResultsViewModel();
	}
}