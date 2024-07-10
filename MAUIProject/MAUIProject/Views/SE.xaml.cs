using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class SE : ContentPage
{
	public SE( SEViewModel sEViewModel)
	{
		InitializeComponent();
        BindingContext = sEViewModel;
    }
}