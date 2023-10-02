using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Icu.Text.CaseMap;

namespace MyFirstMobileApp.ViewViewModels.InnerStackLayoutContents
{
    public class InnerStackLayoutViewModel : BaseViewModel
    {
        // Titles
        public string InnerTitle { get; set; } = InnerTitleLayouts.InnerPageTitle;

        public InnerStackLayoutViewModel()
        {
            Title = TitleLayouts.PageTitle;
            
        }
    }
}






