using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models
{
    //this is where I set the page values after clicking the first button on the first page
    public static class TitleControls
    {
        // getter methods for the titles on the second page (after the mainpage button press) 
        public static string PageTitle { get; } = "Controls Menu";
        public static string SliderTitle { get; } = "Slider";
        public static string StepperTitle { get; } = "Stepper";
        public static string SwitchTitle { get; } = "Switch";
        public static string EntryTitle { get; } = "Entry";
        public static string PickerTitle { get; } = "Picker";
        public static string DatePickerTitle { get; } = "Date and Time Picker";


    }
}
