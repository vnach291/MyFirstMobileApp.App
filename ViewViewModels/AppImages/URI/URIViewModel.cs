using MyFirstMobileApp.Models.AppModels;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.AppImages.URI
{
    public class URIViewModel : BaseViewModel
    {
        public string OLetterURL { get; } = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOSUMhXTiHSCDjNlk_Ew1phU3deG25VHLi11jrhztjzZjnNqSsQG8jj-s6yEhj8XtNO6U:https://static.wikia.nocookie.net/unofficial-alphabet-lore/images/c/c7/ONew.png/revision/latest%3Fcb%3D20221031191907&usqp=CAU";

        private ImageSource _getImageSource;

        public URIViewModel() {

            Title = URITitleLayouts.InnerPageTitle;
        
        }

        //public ImageSource 

    }
}
