using MyFirstMobileApp.ViewViewModels.InnerHorizontalStackLayoutContents;

namespace MyFirstMobileApp.ViewViewModels.InnerFlexStackLayoutContents;

public partial class InnerFlexStackLayoutView : ContentPage
{
	public InnerFlexStackLayoutView()
	{
		InitializeComponent();
        BindingContext = new InnerFlexStackLayoutViewModel();
    }
}