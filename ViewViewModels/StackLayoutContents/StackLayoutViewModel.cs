using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.InnerStackLayoutContents;
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

        public ICommand OnLayoutsClicked { get; set; }
        //Constructor 
        public StackLayoutViewModel() 
        {
            Title = TitleLayouts.PageTitle;
            InnerStackLayoutTitle = TitleLayouts.InnerStackLayoutTitle;
            VerticalStackTitle = TitleLayouts.VerticalStackTitle;
            HorizontalStackTitle = TitleLayouts.HorizontalStackTitle;
            AbsoluteLayoutTitle = TitleLayouts.AbsoluteLayoutTitle;

            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);

        }

        //need another method to make button work, and travel to the next page --> borrow this same setup from the titlemain page
        private async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InnerStackLayoutView());
        }
    }
}
