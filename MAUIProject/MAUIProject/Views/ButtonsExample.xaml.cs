using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class ButtonsExample : ContentPage
{
	public ButtonsExample( ButtonViewModel buttonViewModel)
	{

		InitializeComponent();
		BindingContext = buttonViewModel;
       
    }

}