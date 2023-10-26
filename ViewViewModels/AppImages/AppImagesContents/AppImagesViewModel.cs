using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.AppImages.ActivityIndicator;
using MyFirstMobileApp.ViewViewModels.AppImages.Embedded;
using MyFirstMobileApp.ViewViewModels.AppImages.URI;
using MyFirstMobileApp.ViewViewModels.InnerStackLayoutContents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.AppImages.AppImagesContents
{
    public class AppImagesViewModel : BaseViewModel
    {
        public string Title { get; set; } = TitleApps.PageTitle;
        public string URIImagesTitle { get; set; } = TitleApps.URIImages;
        public string EmbeddedImagesTitle { get; set; } = TitleApps.EmbeddedImages;
        public string ActivityIndicatorTitle { get; set; } = TitleApps.ActivityIndicator;

        public ICommand OnLayoutsClickedtoURIImages { get; set; }
        public ICommand OnLayoutsClickedToEmbeddedImages { get; set; }
        public ICommand OnLayoutsClickedToActivityIndicator { get; set; }

        public AppImagesViewModel() 
        {
            Title = TitleApps.PageTitle;
            URIImagesTitle = TitleApps.URIImages;
            EmbeddedImagesTitle = TitleApps.EmbeddedImages;
            ActivityIndicatorTitle = TitleApps.ActivityIndicator;

            OnLayoutsClickedtoURIImages = new Command(OnLayoutsClickedAsynctoURIImages);
            OnLayoutsClickedToEmbeddedImages = new Command(OnLayoutsClickedAsynctoEmbeddedImages);
            OnLayoutsClickedToActivityIndicator = new Command(OnLayoutsClickedAsyncToActivityIndicator);
        }
        private async void OnLayoutsClickedAsynctoURIImages()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new URIView());
        }

        private async void OnLayoutsClickedAsynctoEmbeddedImages()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedView());
        }
        private async void OnLayoutsClickedAsyncToActivityIndicator()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ActivityIndicatorView());
        }



    }
}
