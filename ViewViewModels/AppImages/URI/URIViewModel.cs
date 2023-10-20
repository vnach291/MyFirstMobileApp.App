using MyFirstMobileApp.Models.AppModels;
using MyFirstMobileApp.Models.InnerModels;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.AppImages.URI
{
    public class URIViewModel : BaseViewModel
    {
        public string OLetterURL { get; set; } = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOSUMhXTiHSCDjNlk_Ew1phU3deG25VHLi11jrhztjzZjnNqSsQG8jj-s6yEhj8XtNO6U:https://static.wikia.nocookie.net/unofficial-alphabet-lore/images/c/c7/ONew.png/revision/latest%3Fcb%3D20221031191907&usqp=CAU";
        public string InnerPageTitle { get; set; } = URITitleLayouts.InnerPageTitle;

        private ImageSource _getImageSource;

        public URIViewModel() {

            Title = URITitleLayouts.InnerPageTitle;
        
        }

        public ImageSource GetImageSource
        { 
        
            get
            {
                if (_getImageSource == null)
                {
                    _getImageSource = GetImage();
                }
                return _getImageSource; 
            }
        }

        private ImageSource GetImage() 
        {
            OLetterURL = "https://upload.wikimedia.org/wikipedia/commons/5/5e/2019_Chevrolet_Camaro_2SS_6.2L_front_3.16.19.jpg";
            var imgsrc = new UriImageSource { Uri = new Uri(OLetterURL) };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);
            return imgsrc;

        }

    }
}
