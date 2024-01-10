using MyFirstMobileApp.Models.ControlsModels;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Controls.PickerControls.PickerResults
{
    public class PickerResultsViewModel : BaseViewModel
    {
        public ImageSource ImageSrc { get; set; }
        public string PickerSelection { get; set; }

        public PickerResultsViewModel(string value, ImageSource image)
        {
            Title = TitlePickers.PickerResultTitle;
            PickerSelection = value;
            ImageSrc = image;
        }
    }
}
