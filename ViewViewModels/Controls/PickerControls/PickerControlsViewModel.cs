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
        public ICommand DnTPickerClicked { get; set; }
        public ICommand ListPickerClicked { get; set; }
        public PickerControlsViewModel()
        {
            // change 
            //Title = TitleAPPControl

            DnTPickerClicked = new Command(DnTClickedAsync);
            ListPickerClicked = new Command(ListClickedAsync);
        }

        public async void DnTClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DnTPickerView()); 
        }

        public async void ListClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListPickerView());
        }


    }
}
