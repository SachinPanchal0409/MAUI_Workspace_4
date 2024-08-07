using MAUIProject.ViewModels;
namespace MAUIProject.Views;

public partial class BiometricExample : ContentPage
{
	public BiometricExample(BiometricViewModel biometricViewModel)
	{
		InitializeComponent();
		BindingContext = biometricViewModel;
	}

	
}