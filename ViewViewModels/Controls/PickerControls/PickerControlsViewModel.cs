using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Controls.PickerControls.ListPicker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Controls.PickerControls
{
    internal class PickerControlsViewModel : BaseViewModel
    {
        public ICommand OnXAMLClicked { get; set; }
        public ICommand OnVMClicked { get; set; }
        public PickerControlsViewModel()
        {
            // change 
            //Title = TitleAPPControl

            OnXAMLClicked = new Command(OnXAMLClickedAsync);
            OnVMClicked = new Command(OnVMClickedAsync);
        }

        public async void OnXAMLClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerXAMLView()); 
        }

        public async void OnVMClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerVMView());
        }


    }
}
