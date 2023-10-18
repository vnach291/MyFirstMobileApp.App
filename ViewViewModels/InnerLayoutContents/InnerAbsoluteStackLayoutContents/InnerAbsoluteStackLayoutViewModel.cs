using MyFirstMobileApp.Models.InnerModels;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.InnerAbsoluteStackLayoutContents
{
    public class InnerAbsoluteStackLayoutViewModel : BaseViewModel
    {
        public string InnerTitle { get; set; } = InnerAbsoluteTitleLayouts.InnerPageTitle;

        public InnerAbsoluteStackLayoutViewModel()
        {
            Title = InnerAbsoluteTitleLayouts.InnerPageTitle;

        }
    }
}
