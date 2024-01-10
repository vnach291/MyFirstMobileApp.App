using MyFirstMobileApp.Models.ControlsModels;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Controls.DatePickerControls.DatePickerVM;
using MyFirstMobileApp.ViewViewModels.Controls.DatePickerControls.DatePickerXAML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Controls.DatePickerControls
{
    public class DatePickerControlsViewModel : BaseViewModel
    {
        public ICommand OnDatePickerXAMLClicked { get; set; }
        public ICommand OnDatePickerVMClicked { get; set; }

        public DatePickerControlsViewModel()
        {
            Title = TitleDatePickers.DatePickerViewTitle;

            OnDatePickerXAMLClicked = new Command(OnXAMLClickedAsync);
            OnDatePickerVMClicked = new Command(OnVMClickedAsync);

        }
        private async void OnXAMLClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerXAMLView());
        }
        private async void OnVMClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerVMView());
        }
    }
}
