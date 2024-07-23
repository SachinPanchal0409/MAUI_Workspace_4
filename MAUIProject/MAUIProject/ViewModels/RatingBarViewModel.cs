using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUIProject.ViewModels
{
    public partial class RatingBarViewModel : ObservableObject
    {
    //    private int _rating;

    //    public RatingBarViewModel()
    //    {
           
    //        Rating = 0;
    //    }

    //    public int Rating
    //    {
    //        get { return _rating; }
    //        set
    //        {
    //            if (_rating != value)
    //            {
    //                _rating = value;
    //                OnPropertyChanged();
    //            }
    //        }
    //    }

    //    public ObservableCollection<string> RatingIcons { get; } = new ObservableCollection<string>
    //    {
    //        "star.png",   
    //        "star.png",
    //        "star.png",
    //        "star.png",
    //        "star.png"
    //    };

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}

    //[ObservableProperty]
    //public string name;

    //public RatingBarViewModel()
    //{

    //}

    //[RelayCommand]
    //public void SubmitName()
    //{
    //    Console.WriteLine("Name: " + Name);
    //}

}

}
