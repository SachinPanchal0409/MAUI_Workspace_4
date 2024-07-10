using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class SeniorTeamLead : ContentPage
{
	public SeniorTeamLead(SeniorTeamLeadViewModel seniorTeamLeadViewModel)
	{
		InitializeComponent();
        BindingContext = seniorTeamLeadViewModel;
    }
}