using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Controls.SwitchControls
{
    public class SwitchControlsViewModel : BaseViewModel
    {
        public bool Button1Initial { get; set; } = true;
        public bool Button2Initial { get; set; } = false;
    
        public SwitchControlsViewModel()
        {
            //
        }


    }

}
