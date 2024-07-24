using CommunityToolkit.Maui;
using MAUIProject.ViewModels;
using MAUIProject.Views;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace MAUIProject
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<INavigation>(provider => App.Current.MainPage.Navigation);
            builder.Services.AddTransient<ProjectManager>();
            builder.Services.AddTransient<ProjectManagerViewModel>();
            builder.Services.AddTransient<SeniorTeamLeadViewModel>();
            builder.Services.AddTransient<SeniorTeamLead>();
            builder.Services.AddTransient<TeamLead>();
            builder.Services.AddTransient<TeamLeadViewModel>();
            builder.Services.AddTransient<SE>();
            builder.Services.AddTransient<SEViewModel>();
            builder.Services.AddTransient<TSE>();
            builder.Services.AddTransient<TSEViewModel>();
            builder.Services.AddTransient<Trainee>();
            builder.Services.AddTransient<TraineeViewModel>();
            builder.Services.AddTransient<RefreshViewExample>();
            builder.Services.AddTransient<RefreshViewModel>();
            builder.Services.AddTransient<ProgressBarExample>();
            builder.Services.AddTransient<ProgressBarViewModel>();
            builder.Services.AddTransient<ButtonsExample>();
            builder.Services.AddTransient<ButtonViewModel>();
            builder.Services.AddTransient<CollectionViewExample>();
            builder.Services.AddTransient<CollectionViewExampleViewModel>();
            builder.Services.AddTransient<DetailsPage>();
            builder.Services.AddTransient<DetailsPageViewModel>();
            builder.Services.AddTransient<ListViewExample>();
            builder.Services.AddTransient<ListViewExampleViewModel>();
            builder.Services.AddTransient<CarouselViewExample>();
            builder.Services.AddTransient<CarouselViewExampleViewModel>();
            builder.Services.AddTransient<RatingBarExample>();
            builder.Services.AddTransient<RatingBarViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
