using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.ControlsModels;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Controls.EntryControls
{
    public class EntryControlsViewModel : BaseViewModel
    {
        public ICommand OnEntryClicked { get; }
        
        private string _entryText = string.Empty; 
        

        public EntryControlsViewModel()
        {
            Title = TitleEntries.EntryVMTitle; 
            OnEntryClicked = new Command(OnEntryClickedAsync);
        }

        public string EntryText
        {
            get
            {
                return _entryText;
            }

            set
            {
                if(_entryText != value)
                    SetProperty(ref _entryText, value); 
            }
        }

        private async void OnEntryClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(TitleEntries.EntryVMTitle, "Entry can't be empty!", "OK");
                return; 
            }

            await Application.Current.MainPage.Navigation.PushAsync(new EntryResultsView(_entryText));
        }
    }
}
