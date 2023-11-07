using MyFirstMobileApp.Models.CollectionsModels;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Models.Utilities;
using MyFirstMobileApp.ViewModels;
using System.Windows.Input;

#pragma warning disable CA1416 // Validate platform compatibility
namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit
{
    public class AddCollectionViewModel : BaseViewModel
    {
        public ICommand SaveBtnClicked { get; set; }
        private string _elementName = string.Empty;

        public AddCollectionViewModel()
        {
            Title = TitlesMisc.AddTitle;
            SaveBtnClicked = new Command(PerformSave);
        }

        public string MovieName
        {
            get { return _elementName; }

            set
            {
                if (_elementName != value)
                    SetProperty(ref _elementName, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_elementName.Trim()))
            {
                // Use Page.DisplayAlert to display the alert
                Application.Current.MainPage.DisplayAlert(TitlesMisc.AddTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            PeriodicElements elements = new PeriodicElements();
            elements.NameofElement = _elementName;

            MessagingCenter.Send<PeriodicElements>(elements, "AddElements");

            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                navigationPage.Navigation.PopAsync();
            }
        }
    }
}
#pragma warning restore CA1416 // Validate platform compatibility