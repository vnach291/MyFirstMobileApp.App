using Android.Runtime;
using MyFirstMobileApp.Models.ControlsModels;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Controls.PickerControls.PickerResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Controls.PickerControls.PickerXAML
{
    public class PickerXAMLViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; set; } = "Images/submit.png";
        public ICommand OnSubmitClicked { get; }

        private string _selectedElement = string.Empty;

        public PickerXAMLViewModel()
        {
            Title = TitlePickers.PickerXAMLTitle; 
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        public string SelectedElement
        {
            get { return _selectedElement; }

            set
            {
                if(_selectedElement != value)
                {
                    SetProperty(ref _selectedElement, value);
                }
            }
        }

        private async void OnSubmitClickedAsync(Object obj)
        {
            List<ElementDiagrams> elms = ElementDiagrams.GetSampleElementData();
            var result = elms.FirstOrDefault(x => x.ElementName.Equals(_selectedElement));
            await Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView(result.ElementName, result.ElementImage));

            if(String.IsNullOrEmpty(_selectedElement))
            {
                await Application.Current.MainPage.DisplayAlert(TitlePickers.PickerXAMLTitle, "A selection must be made", "OK");
                return;
            }
            

        }

    }
}
