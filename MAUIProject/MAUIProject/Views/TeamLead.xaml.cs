// TeamLead.xaml.cs
using MAUIProject.ViewModels;
using Microsoft.Maui.Controls;

namespace MAUIProject.Views
{
    public partial class TeamLead : ContentPage
    {
        public TeamLead(TeamLeadViewModel teamLeadViewModel)
        {
            InitializeComponent();
            BindingContext = teamLeadViewModel;
        }
    }
}
