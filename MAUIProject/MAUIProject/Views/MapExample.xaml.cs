using MAUIProject.ViewModels;
using System.ComponentModel;

namespace MAUIProject.Views
{
    public partial class MapExample : ContentPage
    {
        private MapViewModel _mapViewModel;

        public MapExample(MapViewModel mapViewModel)
        {
            InitializeComponent();
            _mapViewModel = mapViewModel;
            BindingContext = _mapViewModel;
            _mapViewModel.PropertyChanged += OnMapViewModelPropertyChanged;
            SetInitialMapRegion(_mapViewModel);
        }

        private void OnMapViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MapViewModel.MapSpan))
            {
                SetInitialMapRegion(_mapViewModel);
            }
        }

        private void SetInitialMapRegion(MapViewModel viewModel)
        {
            map.MoveToRegion(viewModel.MapSpan);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _mapViewModel.PropertyChanged -= OnMapViewModelPropertyChanged;
        }
    }
}

//using MAUIProject.ViewModels;

//namespace MAUIProject.Views
//{
//    public partial class MapExample : ContentPage
//    {
//        public MapExample(MapViewModel mapViewModel)
//        {
//            InitializeComponent();
//            BindingContext = mapViewModel;
//            SetInitialMapRegion(mapViewModel);
//        }

//        private void SetInitialMapRegion(MapViewModel viewModel)
//        {

//            map.MoveToRegion(viewModel.MapSpan);
//        }
//    }
//}
