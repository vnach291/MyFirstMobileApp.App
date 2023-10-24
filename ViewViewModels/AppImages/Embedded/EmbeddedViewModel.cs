using MyFirstMobileApp.Models.AppModels;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.AppImages.Embedded
{
    public class EmbeddedViewModel : BaseViewModel
    {
        public EmbeddedViewModel() 
        {
            Title = EmbeddedTitleLayouts.InnerPageTitle;
        }

        public ImageSource GetImageSource
        { 
            get
            {
                return ImageSource.FromFile("Images/bobafett.jpg");
            }
        }
    }
}
