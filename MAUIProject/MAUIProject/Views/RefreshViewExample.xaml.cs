namespace MAUIProject.Views;

public partial class RefreshViewExample : ContentPage
{
	public RefreshViewExample(RefreshViewModel refreshViewExample)
	{
        InitializeComponent();
        BindingContext = refreshViewExample;
    }
}