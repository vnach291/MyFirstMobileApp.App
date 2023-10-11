using MyFirstMobileApp.ViewViewModels.StackLayoutContents;

namespace MyFirstMobileApp.ViewViewModels.InnerVerticalStackLayoutContents;

public partial class InnerVerticalStackLayoutView : ContentPage
{
	public InnerVerticalStackLayoutView()
	{
		InitializeComponent();
        BindingContext = new InnerVerticalStackLayoutViewModel();
    }
}