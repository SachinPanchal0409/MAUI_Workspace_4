using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using Plugin.Maui.Biometric;
using System.Windows.Input;

namespace MAUIProject.ViewModels
{
    public partial class BiometricViewModel : ObservableObject
    {
        public ICommand OnAuthenticateButtonCommand { get; }
        public BiometricViewModel() 
        {
            OnAuthenticateButtonCommand = new Command(async () => await ExecuteOnAuthenticateButtonCommand());
        }
        private async Task ExecuteOnAuthenticateButtonCommand()
        {
            var result = await BiometricAuthenticationService.Default.AuthenticateAsync(new AuthenticationRequest()
            {
                Title = "Please Authenticate to move forward!",
                NegativeText = "Cancel",
            }, CancellationToken.None);

            if (result.Status == BiometricResponseStatus.Success)
            {
                Toast.Make("Authentication Successful!").Show();
            }
            else
            {
                Toast.Make("Authentication Failed!").Show();
            }
        }
    }
}
