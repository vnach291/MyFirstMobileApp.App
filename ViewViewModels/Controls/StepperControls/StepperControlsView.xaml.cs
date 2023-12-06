namespace MyFirstMobileApp.ViewViewModels.Controls.StepperControls;

public partial class StepperControlsView : ContentPage
{
    public StepperControlsView()
    {
        InitializeComponent();
        BindingContext = new StepperControlsViewModel();
    }

    public void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        RotatingText.Rotation = value;
        int R = (int)(value / 360 * 255);
        int G = (int)(value / 360 * 184);
        int B = (int)(value / 360 * 200);
        DisplayLabel.TextColor = Color.FromRgb(R, G, B);
        DisplayLabel.Text = string.Format("The Stepper value is {0}", value);
    }
}