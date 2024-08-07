using MAUIProject.ViewModels;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace MAUIProject.Views;

public partial class BiometricAlternativeExample : ContentPage
{
	public BiometricAlternativeExample(BiometricAlternativeViewModel biometricAlternativeViewModel)
	{
		InitializeComponent();
        BindingContext = biometricAlternativeViewModel;
	}
 
}