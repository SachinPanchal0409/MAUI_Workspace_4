using MAUIProject.Models;
using MAUIProject.ViewModels;

namespace MAUIProject.Views;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(DetailsPageViewModel detailsPageViewModel)
    {
        InitializeComponent();
        BindingContext = detailsPageViewModel;
    }

}