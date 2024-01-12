using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.ControlsModels;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Controls.EntryControls
{
    public class EntryResultsViewModel : BaseViewModel
    {
        private string _entryText; 
        public EntryResultsViewModel(string entryText)
        {
            Title = TitleEntries.EntryResultTitle;
            _entryText = entryText;
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
                {
                    SetProperty(ref _entryText, value);
                }
            }
        }
    }
}
