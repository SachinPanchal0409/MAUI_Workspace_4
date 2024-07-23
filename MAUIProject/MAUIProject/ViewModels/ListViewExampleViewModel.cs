using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIProject.Models;
using MAUIProject.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIProject.ViewModels
{
    public partial class ListViewExampleViewModel : ObservableObject
    {

        public ObservableCollection<ListViewModel> Items { get; set; }
        public ObservableCollection<ListViewModel> UnfilteredItemsList { get; set; }

        public ListViewExampleViewModel()
        {
            Items = new ObservableCollection<ListViewModel>()
            {
                new ListViewModel { Name = "Plain Dosa", Price = 70, ImageUrl = "dosa.jpg", Type="Food" },
                new ListViewModel { Name = "Iced Latte Coffee", Price = 150, ImageUrl = "coldcoffee.jpg", Type="Beverages" },
                new ListViewModel { Name = "Aloo tiki Burger", Price = 70, ImageUrl = "burger.jpg" , Type="Food"},
                new ListViewModel { Name = "French Fries Salted", Price = 60, ImageUrl = "fries.jpg", Type="Food" },
                new ListViewModel { Name = "Hot Coffee", Price = 50, ImageUrl = "hotcoffee.jpg", Type="Beverages" },
                new ListViewModel { Name = "Veg Crispy Burger", Price = 130, ImageUrl = "burger.jpg", Type="Food" },
                new ListViewModel { Name = "Mysore Dosa", Price = 170, ImageUrl = "dosa.jpg", Type="Food" },
                new ListViewModel { Name = "Peri Peri Fries", Price = 80, ImageUrl = "fries.jpg" , Type="Food"},
                new ListViewModel { Name = "Idli Sambhar", Price = 90, ImageUrl = "idli.jpg", Type="Food" },
                new ListViewModel { Name = "Cold Coffee Classic", Price = 80, ImageUrl = "coldcoffee.jpg", Type="Beverages" },
                new ListViewModel { Name = "Uttapam", Price = 70, ImageUrl = "uttapam.jpg", Type="Food" },
                new ListViewModel { Name = "Corn and Crispy burger", Price = 180, ImageUrl = "burger.jpg" , Type="Food"},
                new ListViewModel { Name = "Cold Drinks", Price = 40, ImageUrl = "colddrink.jpg", Type="Beverages" }

            };
       
            UnfilteredItemsList = new ObservableCollection<ListViewModel>(Items);
        }

        [RelayCommand]
        public async Task FilterButtonList()
        {
            string action = await App.Current.MainPage.DisplayActionSheet("Filter:", "Cancel", null, "All", "A-Z", "Z-A", "By Price Asc", "By Price Desc", "By Name", "By Type");

            List<ListViewModel> filteredItems;

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


            UnfilteredItemsList.Clear();
            foreach (var item in filteredItems)
            {
                UnfilteredItemsList.Add(item);
            }
        }
    }
}
