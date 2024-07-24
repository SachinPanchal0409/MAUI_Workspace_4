using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class ListViewExample : ContentPage
{
	public ListViewExample(ListViewExampleViewModel listViewExampleViewModel)
	{
		InitializeComponent();
		BindingContext = listViewExampleViewModel;
	}
}