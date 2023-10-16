using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.InnerFlexStackLayoutContents
{
    public class InnerFlexStackLayoutViewModel : BaseViewModel
    {
        public string InnerTitle { get; set; } = InnerFlexTitleLayouts.InnerPageTitle;

        public InnerFlexStackLayoutViewModel()
        {
            Title = InnerFlexTitleLayouts.InnerPageTitle;

        }
    }
}
