namespace MAUIProject.Views;

public partial class RefreshViewDemo : ContentPage
{
	public RefreshViewDemo(RefreshViewDemo refreshViewDemo)
	{
		InitializeComponent();
		BindingContext = refreshViewDemo;
	}
}