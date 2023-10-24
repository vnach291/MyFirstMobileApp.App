using MyFirstMobileApp.Models.AppModels;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.AppImages.ActivityIndicator
{
    public class ActivityIndicatorViewModel : BaseViewModel
    {
        private ImageSource _getimageSource;
        private bool _isLoading;
        private bool _isImageVisible;

        public ActivityIndicatorViewModel() 
        {
            Title = ActivityIndicatorTitleLayouts.InnerPageTitle;
            // FIX AYOOOOAOAO
            _isLoading = true; 

        }

    }
}
