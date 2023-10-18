using MyFirstMobileApp.Models.InnerModels;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.InnerVerticalStackLayoutContents
{
    public class InnerVerticalStackLayoutViewModel : BaseViewModel
    {
        public string InnerTitle { get; set; } = InnerVerticalTitleLayouts.InnerPageTitle;

        public InnerVerticalStackLayoutViewModel()
        {
            Title = InnerVerticalTitleLayouts.InnerPageTitle;

        }
    }
}












