using MyFirstMobileApp.Models;
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
        public string EntryValueText { get; set; }
        public EntryResultsViewModel()
        {
            Title = TitleControls.EntryTitle;
        }
    }
}
