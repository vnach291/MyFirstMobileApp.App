using MyFirstMobileApp.Models.ControlsModels;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Controls.PickerControls.PickerVM
{
    public class PickerVMViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; set; } = "Images/submit.png";

        //Property to bind the Picker Item Source
        public List<string> ElementList { get; set; }
        List<ElementDiagrams> _elements; 
        string _selectedElement = string.Empty;
            
        public ICommand OnSubmitClicked { get; }

        public PickerVMViewModel()
        {
            // Set Title
            //Title = 

            // Get elements from ElementDiagrams to Populate Picker
            this.GetElementList();

            // Set Submit Button Command
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        private void GetElementList()
        {
            var allElementInfo = ElementDiagrams.GetSampleElementData();

            // Filter and map the element names from the list of ElementDiagram objects
            ElementList = allElementInfo.Select(info => info.ElementName).ToList();
            _elements = allElementInfo; 
        }

        public string SelectedElement
        {
            get
            {
                return _selectedElement;
            }
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
            // Verify User made a selection
            if(string.IsNullOrEmpty(_selectedElement))
            {
                await Application.Current.MainPage.DisplayAlert(TitlePickers.PickerVMTitle, "A Selection must be made!", "OK");
                return;
            }

            // Get selection
            var selectedElementName = _selectedElement;

            // Find the element based on the selected element name
            var selectedElementInfo = _elements.FirstOrDefault(info => info.ElementName == selectedElementName);

            if(selectedElementInfo != null)
            {
                // Combining element name and abbreviateion into a single string for display
                string name = $"{selectedElementInfo.ElementName} As {selectedElementInfo.ElementAbbreviation}";

                //Use selected ElementInfo.ElementImage for the element image
                await Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView(name, selectedElementInfo.ElementImage));
            }
        }

    }
}
