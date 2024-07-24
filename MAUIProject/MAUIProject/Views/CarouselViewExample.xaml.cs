using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class CarouselViewExample : ContentPage
{
	public CarouselViewExample(CarouselViewExampleViewModel carouselViewExampleViewModel)
	{
		InitializeComponent();
		BindingContext = carouselViewExampleViewModel;
	}
}