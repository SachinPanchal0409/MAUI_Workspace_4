using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class Trainee : ContentPage
{
	public Trainee(TraineeViewModel traineeViewModel)
	{
		InitializeComponent();
        BindingContext = traineeViewModel;
    }
}