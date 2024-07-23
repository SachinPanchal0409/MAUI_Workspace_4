using MAUIProject.Models;

namespace MAUIProject.ViewModels
{
    public class CarouselViewExampleViewModel
    {
        public List<CarouselViewModel> Items { get; set; }
        public CarouselViewExampleViewModel()
        {
            Items = new List<CarouselViewModel>()
            {
                new CarouselViewModel { Name = "Plain Dosa", Price = 70, ImageUrl = "dosa.jpg", Type="Food",Rating = "5" },
                new CarouselViewModel { Name = "Iced Latte Coffee", Price = 150, ImageUrl = "coldcoffee.jpg", Type="Beverages" ,Rating = "4.5"},
                new CarouselViewModel { Name = "Aloo tiki Burger", Price = 70, ImageUrl = "burger.jpg" , Type="Food" ,Rating = "3"},
                new CarouselViewModel { Name = "French Fries Salted", Price = 60, ImageUrl = "fries.jpg", Type="Food" ,Rating = "3.8" },
                new CarouselViewModel { Name = "Hot Coffee", Price = 50, ImageUrl = "hotcoffee.jpg", Type="Beverages" ,Rating = "4.8"},
                new CarouselViewModel { Name = "Veg Crispy Burger", Price = 130, ImageUrl = "burger.jpg", Type="Food",Rating = "5"},
                new CarouselViewModel { Name = "Mysore Dosa", Price = 170, ImageUrl = "dosa.jpg", Type="Food",Rating = "3.5" },
                new CarouselViewModel { Name = "Peri Peri Fries", Price = 80, ImageUrl = "fries.jpg" , Type="Food",Rating = "4.5"},
                new CarouselViewModel { Name = "Idli Sambhar", Price = 90, ImageUrl = "idli.jpg", Type="Food" ,Rating = "5"},
                new CarouselViewModel { Name = "Cold Coffee Classic", Price = 80, ImageUrl = "coldcoffee.jpg", Type="Beverages",Rating = "5" },
                new CarouselViewModel { Name = "Uttapam", Price = 70, ImageUrl = "uttapam.jpg", Type="Food" ,Rating = "3.4"},
                new CarouselViewModel { Name = "Corn and Crispy burger", Price = 180, ImageUrl = "burger.jpg" , Type="Food",Rating = "5"},
                new CarouselViewModel { Name = "Cold Drinks", Price = 40, ImageUrl = "colddrink.jpg", Type="Beverages" ,Rating = "4.9"}

            };
        }


    }
}
