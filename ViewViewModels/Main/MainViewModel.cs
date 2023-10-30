using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.AppImages.AppImagesContents;
using MyFirstMobileApp.ViewViewModels.Collections.CollectionsContents;
using MyFirstMobileApp.ViewViewModels.StackLayoutContents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        public string ImageTitle { get; }
        public string CollectionTitle { get; private set; }
        public string ControlTitle { get; }
        public string SQLLiteTitle { get; }

        //public String Layouts { get; set; } = TitleMain.Layouts;

        //Button Titles


        //Button Commands
        public ICommand OnLayoutsClicked { get; set; }
        public ICommand OnLayoutsClickedToImages { get; set; }
        public ICommand OnLayoutsClickedToCollections { get; set; }


        public MainViewModel() 
        {
            Title = TitleMain.mainTitle;
            StackLayoutTitle = TitleMain.StackLayoutTitle;
            ImageTitle = TitleMain.ImageTitle;
            CollectionTitle = TitleMain.CollectionTitle;
            ControlTitle = TitleMain.ControlTitle;
            SQLLiteTitle = TitleMain.SQLLiteTitle; 


            // Set Commands
            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
            OnLayoutsClickedToImages = new Command(OnLayoutsClickedAsyncToImages);
            OnLayoutsClickedToCollections = new Command(OnLayoutsClickedAsyncToCollections);

        }
        private async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView()); 
        }

        private async void OnLayoutsClickedAsyncToImages()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AppImagesView());
        }

        private async void OnLayoutsClickedAsyncToCollections()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CollectionsView());
        }

    }
}
