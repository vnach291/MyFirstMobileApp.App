using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.InnerAbsoluteStackLayoutContents;
using MyFirstMobileApp.ViewViewModels.InnerFlexStackLayoutContents;
using MyFirstMobileApp.ViewViewModels.InnerHorizontalStackLayoutContents;
using MyFirstMobileApp.ViewViewModels.InnerStackLayoutContents;
using MyFirstMobileApp.ViewViewModels.InnerVerticalStackLayoutContents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.StackLayoutContents
{
    public class StackLayoutViewModel : BaseViewModel
    {
        //Titles
        public string Title { get; set; } = TitleLayouts.PageTitle;
        public string InnerStackLayoutTitle { get; set; } = TitleLayouts.InnerStackLayoutTitle;
        public string VerticalStackTitle { get; set; } = TitleLayouts.InnerStackLayoutTitle;
        public string HorizontalStackTitle { get; set; } = TitleLayouts.InnerStackLayoutTitle;
        public string AbsoluteLayoutTitle { get; set; } = TitleLayouts.InnerStackLayoutTitle;
        public string FlexLayoutTitle { get; set; } = TitleLayouts.FlexLayoutTitle;

        public ICommand OnLayoutsClicked { get; set; }
        public ICommand OnLayoutsClickedToVerticalStack { get; set; }
        public ICommand OnLayoutsClickedToHorizontalStack { get; set; }
        public ICommand OnLayoutsClickedToAbsoluteStack { get; set; }
        public ICommand OnLayoutsClickedToFlexStack { get; set; }

        //Constructor 
        public StackLayoutViewModel() 
        {
            Title = TitleLayouts.PageTitle;
            
            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
            OnLayoutsClickedToVerticalStack = new Command(OnLayoutsClickedAsyncToVerticalStack);
            OnLayoutsClickedToHorizontalStack = new Command(OnLayoutsClickedAsyncToHorizontalStack);
            OnLayoutsClickedToAbsoluteStack = new Command(OnLayoutsClickedAsyncToAbsoluteStack);
            OnLayoutsClickedToFlexStack = new Command(OnLayoutsClickedAsyncToFlexStack);



        }

        //need another method to make button work, and travel to the next page --> borrow this same setup from the titlemain page
        private async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InnerStackLayoutView());
        }

        private async void OnLayoutsClickedAsyncToVerticalStack()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InnerVerticalStackLayoutView());
        }

        private async void OnLayoutsClickedAsyncToHorizontalStack()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InnerHorizontalStackLayoutView());
        }
        private async void OnLayoutsClickedAsyncToAbsoluteStack()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InnerAbsoluteStackLayoutView());
        }
        private async void OnLayoutsClickedAsyncToFlexStack()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InnerFlexStackLayoutView());
        }

    }
}
