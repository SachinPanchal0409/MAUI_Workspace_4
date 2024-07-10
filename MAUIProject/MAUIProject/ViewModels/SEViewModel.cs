using MAUIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIProject.ViewModels
{
    public class SEViewModel
    {
        public List<SEModel> SE { get; set; }
        public SEViewModel()
        {
            SE = new List<SEModel>()
            {
                new SEModel { Name = "Kiara", ProjectName = "abc", Salary = 55000, Experience = 3 },
                new SEModel { Name = "Krisha", ProjectName = "xyz", Salary = 50000, Experience = 2 },
                new SEModel { Name = "Richa", ProjectName = "pqr", Salary = 44000, Experience = 1 }

            };
        }
    }
}
