using MyFirstMobileApp.Models.Entities;

namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;

public partial class EditCollectionView : ContentPage
{
	public EditCollectionView(PeriodicElements element)
	{
		InitializeComponent();
		BindingContext = new EditCollectionViewModel();
		ElementTitle.Text = element.NameofElement;
	}
}