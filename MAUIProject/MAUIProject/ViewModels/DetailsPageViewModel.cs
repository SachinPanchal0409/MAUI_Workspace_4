using MAUIProject.Models;
using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.ComponentModel;

namespace MAUIProject.ViewModels
{
    public class DetailsPageViewModel : IQueryAttributable, INotifyPropertyChanged
    {
        private CollectionViewModel item;

        public CollectionViewModel Item
        {
            get => item;
            set
            {
                if (item != value)
                {
                    item = value;
                    OnPropertyChanged("Item");
                }
            }
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Item = query["FoodKey"] as CollectionViewModel;
            OnPropertyChanged("FoodKey");        
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
