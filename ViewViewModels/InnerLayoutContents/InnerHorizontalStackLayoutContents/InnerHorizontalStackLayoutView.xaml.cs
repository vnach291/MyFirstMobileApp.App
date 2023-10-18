namespace MyFirstMobileApp.ViewViewModels.InnerHorizontalStackLayoutContents;

public partial class InnerHorizontalStackLayoutView : ContentPage
{
	public InnerHorizontalStackLayoutView()
	{
		InitializeComponent();
		BindingContext = new InnerHorizontalStackLayoutViewModel(); 
	}
}