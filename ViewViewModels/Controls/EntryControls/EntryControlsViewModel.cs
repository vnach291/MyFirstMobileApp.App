using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Controls.EntryControls
{
    public class EntryControlsViewModel : BaseViewModel
    {
        private string _entryText; 
        public string Title { get; set; } = TitleControls.EntryTitle;

        public EntryControlsViewModel(string entryText)
        {
            Title = TitlesEntry.EntryResultTitle; 
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
                if(_entryText is value)
                    SetProperty(ref _entryText, value); 
            }
        }
    }
}
