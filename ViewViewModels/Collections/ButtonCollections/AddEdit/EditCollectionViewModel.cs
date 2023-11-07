using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Models.Utilities;
using MyFirstMobileApp.ViewModels;
using System.Windows.Input;

#pragma warning disable CA1416 // Validate platform compatibility
namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit
{
    public class EditCollectionViewModel : BaseViewModel
    {
        public ICommand UpdateBtnClicked { get; set; }
        private string _elementName = string.Empty;

        public EditCollectionViewModel()
        {
            Title = TitlesMisc.EditTitle;
            UpdateBtnClicked = new Command(PerformSave);
        }

        public string ElementName
        {
            get { return _elementName; }

            set
            {
                if (_elementName != value)
                    // Use the SetProperty method to update the private field _movies
                    // and trigger property change notifications when the Movies property value changes.
                    SetProperty(ref _elementName, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_elementName.Trim()))
            {
                // Use Page.DisplayAlert to display the alert
                Application.Current.MainPage.DisplayAlert(TitlesMisc.EditTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            PeriodicElements elements = new PeriodicElements();
            elements.NameofElement = _elementName;

            MessagingCenter.Send<PeriodicElements>(elements, "UpdateElements");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
#pragma warning restore CA1416 // Validate platform compatibility
