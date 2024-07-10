using MAUIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIProject.ViewModels
{
    public class TSEViewModel
    {
        public List<TSEModel> TSE { get; set; }
        public TSEViewModel()
        {
            TSE = new List<TSEModel>()
            {
                new TSEModel { Name = "Hiya", ProjectName = "abc", Salary = 36000 },
                new TSEModel { Name = "Disney", ProjectName = "xyz", Salary = 36000 },
                new TSEModel { Name = "Riya", ProjectName = "pqr", Salary = 36000 }

            };
        }
    }
}
