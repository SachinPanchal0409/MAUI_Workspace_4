using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIProject.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MAUIProject.ViewModels
{
    public partial class RatingBarViewModel : ObservableObject
    {

        [ObservableProperty]
        public int rating;

        private RatingBarModel selectedItemData;
        public ICommand ItemSelectedCommand { get; }
        public ObservableCollection<RatingBarModel> Items { get; set; }
        public ObservableCollection<RatingBarModel> Stars { get; set; }
        public RatingBarViewModel()
        {
            Rating = 0;
            Items = new ObservableCollection<RatingBarModel>()
            {
                new RatingBarModel {Value = 1,  ImageUrl = "star.png", Bgcolor = "AliceBlue" },
                new RatingBarModel  {Value = 2,  ImageUrl = "star.png", Bgcolor = "AliceBlue" },
                new RatingBarModel  {Value = 3,  ImageUrl = "star.png", Bgcolor = "AliceBlue" },
                new RatingBarModel  {Value = 4,  ImageUrl = "star.png", Bgcolor = "AliceBlue" },
                new RatingBarModel  {Value = 5,  ImageUrl = "star.png", Bgcolor = "AliceBlue" },
            };
            Stars = new ObservableCollection<RatingBarModel>(Items);
            ItemSelectedCommand = new Command<RatingBarModel>(OnItemSelected);
        }

        public RatingBarModel SelectedItemData
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


        private async void OnItemSelected(RatingBarModel selectedItem)
        {
            Rating = selectedItem.Value;

            for (int i = 0; i < Items.Count; i++)
            {

                if (Items[i].Value <= selectedItem.Value)
                {
                    Stars[i].Value = Items[i].Value;
                    Stars[i].ImageUrl = "starcolor.png";
                    Stars[i].Bgcolor = "CadetBlue";
                }
                else
                {
                    Stars[i].Value = Items[i].Value;
                    Stars[i].ImageUrl = "star.png";
                    Stars[i].Bgcolor = "AliceBlue";
                }

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}





