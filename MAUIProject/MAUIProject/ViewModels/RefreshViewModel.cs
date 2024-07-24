using MAUIProject.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;

public class RefreshViewModel : INotifyPropertyChanged
{
    private bool _isRefreshing;
    private string _name;
    private string _description;
    private string _itemImage;
    private ObservableCollection<RefreshViewExampleModel> _refreshViewExampleModels;
    private ObservableCollection<RefreshViewExampleModel> RefreshViewExampleModelsAll;
    private System.Timers.Timer _refreshTimer;
    public int count = 0;
    Random random = new Random();
    public bool IsRefreshing
    {
        get => _isRefreshing;
        set
        {
            if (_isRefreshing != value)
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            if (_name != value)
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    public string Description
    {
        get => _description;
        set
        {
            if (_description != value)
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
    }

    public string ItemImage
    {
        get => _itemImage;
        set
        {
            if (_itemImage != value)
            {
                _itemImage = value;
                OnPropertyChanged(nameof(ItemImage));
            }
        }
    }

    public ObservableCollection<RefreshViewExampleModel> RefreshViewExampleModels
    {
        get => _refreshViewExampleModels;
        set
        {
            if (_refreshViewExampleModels != value)
            {
                _refreshViewExampleModels = value;
                OnPropertyChanged(nameof(RefreshViewExampleModels));
            }
        }
    }

    public ICommand RefreshCommand { get; }

    public RefreshViewModel()
    {
        RefreshCommand = new Command(async () => await ExecuteRefreshCommand());
        RefreshViewExampleModelsAll = new ObservableCollection<RefreshViewExampleModel>();
        RefreshViewExampleModelsAll.Add(new RefreshViewExampleModel { Name = "Apple", Description = "Lorem ipsum...", ItemImage = "apple.jpg" });
        RefreshViewExampleModelsAll.Add(new RefreshViewExampleModel { Name = "Orange", Description = "Lorem ipsum...", ItemImage = "orange.jpg" });
        RefreshViewExampleModelsAll.Add(new RefreshViewExampleModel { Name = "Strawberry", Description = "Lorem ipsum...", ItemImage = "strawberry.jpg" });
        RefreshViewExampleModelsAll.Add(new RefreshViewExampleModel { Name = "Kiwi", Description = "Lorem ipsum...", ItemImage = "kiwi.jpg" });
        count = RefreshViewExampleModelsAll.Count();
        LoadInitialData(); 
        _refreshTimer = new System.Timers.Timer(5000);
        _refreshTimer.Elapsed += async (sender, e) => await RefreshDataPeriodically();
        _refreshTimer.AutoReset = true;
        _refreshTimer.Enabled = true;

    }

    private void LoadInitialData()
    {
        GetData();
    }

    private ObservableCollection<RefreshViewExampleModel> GetData()
    {
        int randomNumberInRange = random.Next(1, count);
        RefreshViewExampleModels = new ObservableCollection<RefreshViewExampleModel>(RefreshViewExampleModelsAll.Take(randomNumberInRange));
        return RefreshViewExampleModels;
    }
    private async Task ExecuteRefreshCommand()
    {
        IsRefreshing = true;
        await Task.Delay(2000);
        GetData();
        IsRefreshing = false;
    }

    private async Task RefreshDataPeriodically()
    {
        GetData();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}