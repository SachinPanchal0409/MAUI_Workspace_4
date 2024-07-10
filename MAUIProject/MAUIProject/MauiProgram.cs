using MAUIProject.ViewModels;
using MAUIProject.Views;
using Microsoft.Extensions.Logging;

namespace MAUIProject
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
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

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
