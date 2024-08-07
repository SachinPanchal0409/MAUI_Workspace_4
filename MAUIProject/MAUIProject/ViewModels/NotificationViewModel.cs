using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;


namespace MAUIProject.ViewModels
{
    public partial class NotificationViewModel : ObservableObject
    {
        public NotificationViewModel()
        {
            LocalNotificationCenter.Current.NotificationActionTapped += Current_NotificationActionTapped;
        }

        private void Current_NotificationActionTapped(NotificationActionEventArgs e)
        {
            if (e.IsDismissed)
            {
                Toast.Make("Message Dismissed!!").Show();
            }
            else if (e.IsTapped)
            {

            }
        }

        [RelayCommand]
        public void ShowNotification()
        {
            var request = new NotificationRequest
            {
                NotificationId = 1111,
                Title = "Notification from App",
                Subtitle = "Heyy!",
                Description = "Heyy! This notification is for demo purpose. This is just the dummy text notification.",
                BadgeNumber = 42,
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(5),
                    NotifyRepeatInterval = TimeSpan.FromDays(1),
                },


            };


            LocalNotificationCenter.Current.Show(request);
        }
    }
}
