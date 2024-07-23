namespace MAUIProject.Views;

public partial class CommonTemplate : ContentView
{
    public static readonly BindableProperty NameProperty =
            BindableProperty.Create(nameof(Name), typeof(string), typeof(CommonTemplate), default(string), BindingMode.TwoWay);

    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(CommonTemplate), default(string), BindingMode.TwoWay);

    public static readonly BindableProperty CountProperty =
       BindableProperty.Create(nameof(Count), typeof(int), typeof(CommonTemplate), default(int), BindingMode.TwoWay);

    public static readonly BindableProperty MemberCountProperty =
      BindableProperty.Create(nameof(MemberCount), typeof(int), typeof(CommonTemplate), default(int), BindingMode.TwoWay);

    public static readonly BindableProperty IsVisibleMemberCountProperty =
     BindableProperty.Create(nameof(IsVisibleMemberCount), typeof(bool), typeof(CommonTemplate), default(bool), BindingMode.TwoWay);

    public static readonly BindableProperty IsVisibleTitleProperty =
     BindableProperty.Create(nameof(IsVisibleTitle), typeof(bool), typeof(CommonTemplate), default(bool), BindingMode.TwoWay);
    public static readonly BindableProperty ImageSourceProperty =
   BindableProperty.Create(nameof(ImageSource), typeof(ImageSource), typeof(CommonTemplate));

    public ImageSource ImageSource
    {
        get { return GetValue(ImageSourceProperty) as ImageSource; }
        set { SetValue(ImageSourceProperty, value); }
    }
    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public int Count
    {
        get => (int)GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }
    public int MemberCount
    {
        get => (int)GetValue(MemberCountProperty);
        set => SetValue(MemberCountProperty, value);
    }

    public bool IsVisibleMemberCount
    {
        get => (bool)GetValue(IsVisibleMemberCountProperty);
        set => SetValue(IsVisibleMemberCountProperty, value);
    }

    public bool IsVisibleTitle
    {
        get => (bool)GetValue(IsVisibleTitleProperty);
        set => SetValue(IsVisibleTitleProperty, value);
    }
    public CommonTemplate()
	{
		InitializeComponent();
	}
}