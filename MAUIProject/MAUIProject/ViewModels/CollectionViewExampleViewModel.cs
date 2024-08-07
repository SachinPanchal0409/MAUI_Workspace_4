using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIProject.Models;
using System.Windows.Input;
using System.Collections.ObjectModel;


namespace MAUIProject.ViewModels
{
    public partial class CollectionViewExampleViewModel : ObservableObject
    {
        private CollectionViewModel selectedItemData;
        public ICommand ItemSelectedCommand { get; }
        public CollectionViewModel SelectedItemData
        {
            get => selectedItemData;
            set
            {
                if (SetProperty(ref selectedItemData, value))
                {
                    ItemSelectedCommand.Execute(selectedItemData);
                }
            }
        }
        public List<CollectionViewModel> Items { get; set; }
        public ObservableCollection<CollectionViewModel> UnfilteredItems { get; set; }
        public CollectionViewExampleViewModel()
        {

            Items = new List<CollectionViewModel>()
            {
                new CollectionViewModel { Name = "Plain Dosa", Price = 70, ImageUrl = "dosa.jpg", Type="Food" },
                new CollectionViewModel { Name = "Iced Latte Coffee", Price = 150, ImageUrl = "coldcoffee.jpg", Type="Beverages" },
                new CollectionViewModel { Name = "Aloo tiki Burger", Price = 70, ImageUrl = "burger.jpg" , Type="Food"},
                new CollectionViewModel { Name = "French Fries Salted", Price = 60, ImageUrl = "fries.jpg", Type="Food" },
                new CollectionViewModel { Name = "Hot Coffee", Price = 50, ImageUrl = "hotcoffee.jpg", Type="Beverages" },
                new CollectionViewModel { Name = "Veg Crispy Burger", Price = 130, ImageUrl = "burger.jpg", Type="Food" },
                new CollectionViewModel { Name = "Mysore Dosa", Price = 170, ImageUrl = "dosa.jpg", Type="Food" },
                new CollectionViewModel { Name = "Peri Peri Fries", Price = 80, ImageUrl = "fries.jpg" , Type="Food"},
                new CollectionViewModel { Name = "Idli Sambhar", Price = 90, ImageUrl = "idli.jpg", Type="Food" },
                new CollectionViewModel { Name = "Cold Coffee Classic", Price = 80, ImageUrl = "coldcoffee.jpg", Type="Beverages" },
                new CollectionViewModel { Name = "Uttapam", Price = 70, ImageUrl = "uttapam.jpg", Type="Food" },
                new CollectionViewModel { Name = "Corn and Crispy burger", Price = 180, ImageUrl = "burger.jpg" , Type="Food"},
                new CollectionViewModel { Name = "Cold Drinks", Price = 40, ImageUrl = "colddrink.jpg", Type="Beverages" }

            };
            UnfilteredItems = new ObservableCollection<CollectionViewModel>(Items);

            ItemSelectedCommand = new Command<CollectionViewModel>(OnItemSelected);
        }

        private async void OnItemSelected(CollectionViewModel selectedItem)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "FoodKey", selectedItem }
            };
            await Shell.Current.GoToAsync("DetailsPage", navigationParameter);
        }

        [RelayCommand]
        public void Favorite()
        {
            Toast.Make("Added to Favorites!", ToastDuration.Long, 16).Show();
        }
        [RelayCommand]
        public void Delete()
        {
            Toast.Make("Deleted Successfully!", ToastDuration.Long, 16).Show();
        }

        public enum ActionChoice
        {
            All,
            Sort,
            Filter
        }

        public enum SortOption
        {
            AZ,
            ZA,
            ByPriceAsc,
            ByPriceDesc
        }

        public enum FilterOption
        {
            ByName,
            ByType
        }

        [RelayCommand]
        public async Task FilterButton()
        {
            ActionChoice action = (ActionChoice)Enum.Parse(typeof(ActionChoice), await App.Current.MainPage.DisplayActionSheet("Choose Filters:", "Cancel", null, ActionChoice.All.ToString(), ActionChoice.Sort.ToString(), ActionChoice.Filter.ToString()));
            List<CollectionViewModel> filteredItems = new List<CollectionViewModel>();

            switch (action)
            {
                case ActionChoice.All:
                    Items = Items.ToList();
                    UpdateUnfilteredItems(Items);
                    break;
                case ActionChoice.Sort:
                    SortOption sortoption = (SortOption)Enum.Parse(typeof(SortOption), await App.Current.MainPage.DisplayActionSheet("Choose Sort Method:", "Cancel", null, SortOption.AZ.ToString(), SortOption.ZA.ToString(), SortOption.ByPriceAsc.ToString(), SortOption.ByPriceDesc.ToString()));
                    await SortFunction(sortoption);
                    break;
                case ActionChoice.Filter:
                    FilterOption filteroption = (FilterOption)Enum.Parse(typeof(FilterOption), await App.Current.MainPage.DisplayActionSheet("Choose Filter Method:", "Cancel", null, FilterOption.ByName.ToString(), FilterOption.ByType.ToString()));
                    await FilterFunction(filteroption, filteredItems);
                    break;
                default:
                    break;
            }
        }
        private async Task SortFunction(SortOption sortoption)
        {
            switch (sortoption)
            {
                case SortOption.AZ:
                    Items = Items.OrderBy(x => x.Name).ToList();            
                    break;
                case SortOption.ZA:
                    Items = Items.OrderByDescending(x => x.Name).ToList();
                   
                    break;
                case SortOption.ByPriceAsc:
                    Items = Items.OrderBy(x => x.Price).ToList();
                    break;
                case SortOption.ByPriceDesc:
                    Items = Items.OrderByDescending(x => x.Price).ToList();
                    break;
                default:
                    break;
            }
            UpdateUnfilteredItems(Items);


        }
       
        private async Task FilterFunction(FilterOption filteroption, List<CollectionViewModel> filteredItems)
        {
            switch (filteroption)
            {
                case FilterOption.ByName:
                    string result = await App.Current.MainPage.DisplayPromptAsync("Search By Name", "Enter Name of Dish");
                    filteredItems.Clear();
                    filteredItems.AddRange(Items.Where(x => x.Name.ToLower().Contains(result.ToLower())));
                    break;
                case FilterOption.ByType:
                    string typeselect = await App.Current.MainPage.DisplayActionSheet("Select Type:", "Cancel", null, "Food", "Beverages");
                    filteredItems.Clear();
                    filteredItems.AddRange(Items.Where(x => x.Type.ToLower() == typeselect.ToLower()));
                    break;
                default:
                    break;
            }
            UpdateUnfilteredItems(filteredItems);
            
        }

        private void UpdateUnfilteredItems(List<CollectionViewModel> updatedItems)
        {
            UnfilteredItems.Clear();
            foreach (var item in updatedItems)
            {
                UnfilteredItems.Add(item);
            }
        }



    }
}
