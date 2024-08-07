using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class NotificationExample : ContentPage
{
	public NotificationExample(NotificationViewModel notificationViewModel)
	{
		InitializeComponent();
		BindingContext = notificationViewModel; 
	}
}