namespace MyFirstMobileApp.ViewViewModels.Controls.SliderControls;

public partial class SliderControlsView : ContentPage
{
	public SliderControlsView()
	{
		InitializeComponent();
		BindingContext = new SliderControlsViewModel();
		this.SetPadding();
	}

	private void SetPadding()
	{
		if(DeviceInfo.Platform == DevicePlatform.iOS)
		{
			Padding = new Thickness(25);
		}

        else if (DeviceInfo.Platform == DevicePlatform.Android)
        {
            Padding = new Thickness(25);
        }
    }

}