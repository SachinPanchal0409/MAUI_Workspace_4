using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class RatingBarExample : ContentPage
{
	public RatingBarExample(RatingBarViewModel ratingBarViewModel)
	{
		InitializeComponent();
		BindingContext = ratingBarViewModel;
	}
}