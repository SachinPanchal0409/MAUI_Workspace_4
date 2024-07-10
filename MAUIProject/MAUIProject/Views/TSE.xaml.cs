using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class TSE : ContentPage
{
	public TSE(TSEViewModel tSEViewModel)
	{
		InitializeComponent();
		BindingContext = tSEViewModel;
    }
}