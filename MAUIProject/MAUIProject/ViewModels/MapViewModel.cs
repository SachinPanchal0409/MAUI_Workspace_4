using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace MAUIProject.ViewModels
{
    public partial class MapViewModel : ObservableObject, INotifyPropertyChanged
    {
        private MapSpan _mapSpan;
     
        private Pin _selectedPin;

        public ObservableCollection<Pin> Pins { get; } = new ObservableCollection<Pin>();

        public MapViewModel()
        {
            var initialLocation = new Location(22, 72);
            MapSpan = MapSpan.FromCenterAndRadius(initialLocation, Distance.FromMiles(100));

            Pins.Add(new Pin
            {
                Label = "Gurukul",
                Address = "Address 1",
                Location = new Location(23.042067, 72.530835)
            });

            Pins.Add(new Pin
            {
                Label = "Satellite",
                Address = "Address 2",
                Location = new Location(23.030357, 72.517845)
            });

            Pins.Add(new Pin
            {
                Label = "Vastrapur",
                Address = "Address 3",
                Location = new Location(23.035007, 72.529324)
            });
        }

        public MapSpan MapSpan
        {
            get => _mapSpan;
            set
            {
                if (_mapSpan != value)
                {
                    _mapSpan = value;
                    OnPropertyChanged();
                }
            }
        }

        public Pin SelectedPin
        {
            get => _selectedPin;
            set
            {
                if (_selectedPin != value)
                {
                    _selectedPin = value;
                    OnPropertyChanged();
                    UpdateMapSpan();
                    
                }
            }
        }

        private void UpdateMapSpan()
        {
            if (_selectedPin != null)
            {
          
                MapSpan = MapSpan.FromCenterAndRadius(_selectedPin.Location, Distance.FromMiles(1));
  
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}