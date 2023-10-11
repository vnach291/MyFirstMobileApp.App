using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.InnerHorizontalStackLayoutContents
{
    public class InnerHorizontalStackLayoutViewModel : BaseViewModel
    {
        public string InnerTitle { get; set; } = InnerHorizontalTitleLayouts.InnerPageTitle;

        public InnerHorizontalStackLayoutViewModel()
        {
            Title = InnerHorizontalTitleLayouts.InnerPageTitle;

        }
    }
}
