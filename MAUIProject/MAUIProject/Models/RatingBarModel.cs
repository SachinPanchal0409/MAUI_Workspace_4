using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIProject.Models
{
    public partial class RatingBarModel : ObservableObject
    {
        [ObservableProperty]
        public int value;
        [ObservableProperty]
        public string imageUrl;
        [ObservableProperty]
        public string bgcolor;
    }
}
