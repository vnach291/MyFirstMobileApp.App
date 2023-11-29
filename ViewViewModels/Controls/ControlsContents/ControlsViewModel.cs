using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Controls.DatePickerControls;
using MyFirstMobileApp.ViewViewModels.Controls.EntryControls;
using MyFirstMobileApp.ViewViewModels.Controls.PickerControls;
using MyFirstMobileApp.ViewViewModels.Controls.SliderControls;
using MyFirstMobileApp.ViewViewModels.Controls.StepperControls;
using MyFirstMobileApp.ViewViewModels.Controls.SwitchControls;
using MyFirstMobileApp.ViewViewModels.InnerStackLayoutContents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Controls.ControlsContents
{
    public class ControlsViewModel : BaseViewModel
    {
        public string Title { get; set; } = TitleControls.PageTitle;
        public string SliderTitle { get; set; } = TitleControls.SliderTitle;
        public string StepperTitle { get; set; } = TitleControls.StepperTitle;
        public string SwitchTitle { get; set; } = TitleControls.SwitchTitle;
        public string EntryTitle { get; set; } = TitleControls.EntryTitle;
        public string PickerTitle { get; set; } = TitleControls.PickerTitle;
        public string DatePickerTitle { get; set; } = TitleControls.DatePickerTitle;

        public ICommand OnLayoutsClickedToSlider { get; set; }
        public ICommand OnLayoutsClickedToStepper { get; set; }
        public ICommand OnLayoutsClickedToSwitch { get; set; }
        public ICommand OnLayoutsClickedToEntry { get; set; }
        public ICommand OnLayoutsClickedToPicker { get; set; }
        public ICommand OnLayoutsClickedToDatePicker { get; set; }

        public ControlsViewModel()
        {
            Title = TitleControls.PageTitle;

            OnLayoutsClickedToSlider = new Command(OnLayoutsClickedAsyncToSlider);
            OnLayoutsClickedToStepper = new Command(OnLayoutsClickedAsyncToStepper);
            OnLayoutsClickedToSwitch = new Command(OnLayoutsClickedAsyncToSwitch);
            OnLayoutsClickedToEntry = new Command(OnLayoutsClickedAsyncToEntry);
            OnLayoutsClickedToPicker = new Command(OnLayoutsClickedAsyncToPicker);
            OnLayoutsClickedToDatePicker = new Command(OnLayoutsClickedAsyncToDatePicker);

        }

        private async void OnLayoutsClickedAsyncToSlider()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SliderControlsView());
        }

        private async void OnLayoutsClickedAsyncToStepper()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StepperControlsView());
        }

        private async void OnLayoutsClickedAsyncToSwitch()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SwitchControlsView());
        }

        private async void OnLayoutsClickedAsyncToEntry()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EntryControlsView());
        }

        private async void OnLayoutsClickedAsyncToPicker()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerControlsView());
        }

        private async void OnLayoutsClickedAsyncToDatePicker()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerControlsView());
        }


    }
}
