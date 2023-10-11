using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models
{
    
    //this is where I set the page values after clicking the first button on the first page
    public static class TitleLayouts
    {
        // getter methods for the titles on the second page (after the mainpage button press) 
        public static string PageTitle { get; } = "Layouts Menu";
        public static string InnerStackLayoutTitle { get; } = "Stack Layout";
        public static string VerticalStackTitle { get; } = "Vertical Stack";
        public static string HorizontalStackTitle { get; } = "Horizontal Stack";
        public static string AbsoluteLayoutTitle { get; } = "Absolute Layout";
        public static string FlexLayoutTitle { get; } = "Flex Layout";
    }
}
