using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIProject.Models;
using System.Collections.ObjectModel;

namespace MAUIProject.ViewModels
{
    public partial class ListViewExampleViewModel : ObservableObject
    {
        public List<ListViewModel> Items { get; set; }
        public ObservableCollection<ListViewModel> UnfilteredItemsList { get; set; }


        public ListViewExampleViewModel()
        {
            Items = new List<ListViewModel>()
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


       

    }
}
