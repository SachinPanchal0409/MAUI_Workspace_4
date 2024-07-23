namespace MAUIProject.Views;

using MAUIProject.ViewModels;
using Microsoft.Maui.Controls;

public partial class ProgressBarExample : ContentPage
{
    public ProgressBarExample(ProgressBarViewModel progressBarViewModel)
    {
        InitializeComponent();
        BindingContext = progressBarViewModel;
    }

    
}
