using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
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

        //public String Layouts { get; set; } = TitleMain.Layouts;

        //Button Titles


        //Button Commands
        public ICommand OnLayoutsClicked { get; set; }

        public MainViewModel() 
        {
            Title = TitleMain.mainTitle;
            StackLayoutTitle = TitleMain.StackLayoutTitle;

            // Set Commands
            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        }
        private async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView()); 
        }

    }
}
