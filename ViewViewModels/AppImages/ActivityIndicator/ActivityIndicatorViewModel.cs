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
            IsLoading = true;
            // initially set images as not visible
            IsImageVisible = false;
            LoadImageAsync();

        }
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public bool IsImageVisible
        {
            get => _isImageVisible;
            set
            {
                _isImageVisible = value;
                OnPropertyChanged(nameof(IsImageVisible));
            }
        }

        public ImageSource GetImageSource
        {
            get => _getimageSource; 
            set
            {
                _getimageSource = value;
                OnPropertyChanged(nameof(GetImageSource));
            }
        }

        private async Task LoadImageAsync()
        {
            try
            {
                using(var client = new HttpClient())
                {
                    // utilizing same url from URIImagesView
                    var response = await client.GetAsync(URITitleLayouts.GetURLImage);

                    if(response.IsSuccessStatusCode)
                    {
                        var stream = await response.Content.ReadAsStreamAsync();
                        GetImageSource = ImageSource.FromStream(() => stream);

                        // Make the image visible
                        IsImageVisible = true; 
                    }

                    else
                    {
                        // handle error or show a placeholder image
                    }

                }
            }

            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the image loading 
                Console.WriteLine($"Error loading image: {ex}");
            }

            finally
            {
                // Set isLoading to false after image has shown up or if there's an error
                IsLoading = false;
            }

        }

    }
}
