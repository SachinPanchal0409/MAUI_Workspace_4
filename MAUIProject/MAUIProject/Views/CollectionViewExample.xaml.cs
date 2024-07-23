using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class CollectionViewExample : ContentPage
{
	public CollectionViewExample(CollectionViewExampleViewModel collectionViewExampleViewModel)
	{
		InitializeComponent();
		BindingContext = collectionViewExampleViewModel;
	}

}