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
        public string OLetterURL { get; set; } = URITitleLayouts.GetURLImage;
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
            var imgsrc = new UriImageSource { Uri = new Uri(OLetterURL) };
            imgsrc.CachingEnabled = true;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);
            return imgsrc;

        }

    }
}
