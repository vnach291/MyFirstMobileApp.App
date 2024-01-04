using MyFirstMobileApp.Models.ControlsModels;

namespace MyFirstMobileApp.ViewViewModels.Controls.EntryControls;

public partial class EntryControlsView : ContentPage
{
	public EntryControlsView()
	{
		InitializeComponent();
		BindingContext = new EntryControlsViewModel();
	}

	private void OnSubmitClicked(object sender, EventArgs e)
	{
		string entryText = EntryValue.Text; 

		if(string.IsNullOrEmpty(entryText))
		{
			// this jsut means nothing was entered; alert the user that nothing was entered
			Application.Current.MainPage.DisplayAlert(TitleEntries.EntryXAMLTitle, "Entry is empty. Please Enter text.", "OK");
		}

		else
		{
			// entry is not empty, tell the user what they inputted
			Application.Current.MainPage.DisplayAlert(TitleEntries.EntryXAMLTitle, "You entered: " + entryText, "OK");
		}
	}

}