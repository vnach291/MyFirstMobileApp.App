using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.AppImages.URI;
using MyFirstMobileApp.ViewViewModels.Collections.ButtonCollections;
using MyFirstMobileApp.ViewViewModels.Collections.IconCollections;
using MyFirstMobileApp.ViewViewModels.Collections.ImageCollections;
using MyFirstMobileApp.ViewViewModels.Collections.NormalCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Collections.CollectionsContents
{
    public class CollectionsViewModel : BaseViewModel
    {
        public string Title { get; set; } = TitleCollections.PageTitle;
        public string NormalCollectionsTitle { get; set; } = TitleCollections.NormalCollections;
        public string ImageCollectionsTitle { get; set; } = TitleCollections.ImageCollections;
        public string ButtonCollectionsTitle { get; set; } = TitleCollections.ButtonCollections;
        public string IconCollectionsTitle { get; set; } = TitleCollections.IconCollections;

        public ICommand OnLayoutsClickedtoNormalCollections { get; set; }
        public ICommand OnLayoutsClickedToImageCollections { get; set; }
        public ICommand OnLayoutsClickedToButtonCollections { get; set; }
        public ICommand OnLayoutsClickedToIconCollections { get; set; }

        public CollectionsViewModel()
        {
            
            Title = TitleCollections.PageTitle;
    
            OnLayoutsClickedtoNormalCollections = new Command(OnLayoutsClickedAsynctoNormalCollections);
            OnLayoutsClickedToImageCollections = new Command(OnLayoutsClickedAsynctoImageCollections);
            OnLayoutsClickedToButtonCollections = new Command(OnLayoutsClickedAsynctoButtonCollections);
            OnLayoutsClickedToIconCollections = new Command(OnLayoutsClickedAsynctoIconCollections);
        }

        private async void OnLayoutsClickedAsynctoNormalCollections()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new NormalCollectionsView());
        }
        private async void OnLayoutsClickedAsynctoImageCollections()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageCollectionsView());
        }
        private async void OnLayoutsClickedAsynctoButtonCollections()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ButtonCollectionsView());
        }
        private async void OnLayoutsClickedAsynctoIconCollections()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new IconCollectionsView());
        }


    }
}
