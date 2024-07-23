using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIProject.Models;
using System.Diagnostics;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MAUIProject.Views;


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
        public ObservableCollection<CollectionViewModel> Items { get; set; }
        public ObservableCollection<CollectionViewModel> UnfilteredItems { get; set; }
        public CollectionViewExampleViewModel() 
        {
            
            Items = new ObservableCollection<CollectionViewModel>()
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
            Toast.Make("Added to Favorites!", ToastDuration.Long,16).Show();
        }
        [RelayCommand]
        public void Delete()
        {
            Toast.Make("Deleted Successfully!", ToastDuration.Long,16).Show();
        }

        [RelayCommand]
        public async Task FilterButton()
        {
            string action = await App.Current.MainPage.DisplayActionSheet("Filter:", "Cancel", null, "All", "A-Z", "Z-A", "By Price Asc", "By Price Desc", "By Name", "By Type");

            List<CollectionViewModel> filteredItems;

            switch (action)
            {
                case "All":
                    filteredItems = Items.ToList();
                    break;
                case "A-Z":
                    filteredItems = Items.OrderBy(x => x.Name).ToList();
                    break;
                case "Z-A":
                    filteredItems = Items.OrderByDescending(x => x.Name).ToList();
                    break;
                case "By Price Asc":
                    filteredItems = Items.OrderBy(x => x.Price).ToList();
                    break;
                case "By Price Desc":
                    filteredItems = Items.OrderByDescending(x => x.Price).ToList();
                    break;
                case "By Name":
                    string result = await App.Current.MainPage.DisplayPromptAsync("Search By Name", "Enter Name of Dish");
                    filteredItems = Items.Where(x => x.Name.ToLower().Contains(result.ToLower())).ToList();
                    break;
                case "By Type":
                    string typeselect = await App.Current.MainPage.DisplayActionSheet("Select Type:", "Cancel", null, "Food", "Beverages");
                    filteredItems = Items.Where(x => x.Type.ToLower() == typeselect.ToLower()).ToList();
                    break;
                default:
                    filteredItems = Items.ToList();
                    break;
            }


            UnfilteredItems.Clear();
            foreach (var item in filteredItems)
            {
                UnfilteredItems.Add(item);
            }
        }



    }
}
