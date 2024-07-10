using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class ProjectManager : ContentPage
{
	public ProjectManager(ProjectManagerViewModel projectManagerViewModel)
	{
		InitializeComponent();
		BindingContext = projectManagerViewModel;
    }
}