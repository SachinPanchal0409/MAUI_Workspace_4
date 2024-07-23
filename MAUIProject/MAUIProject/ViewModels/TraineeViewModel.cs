using MAUIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIProject.ViewModels
{
    public class TraineeViewModel
    {
        public List<TraineeModel> Trainees { get; set; }
        public TraineeViewModel()
        {
            Trainees = new List<TraineeModel>()
            {
                new TraineeModel { Name = "Alice", Age = 25, Address = "A-street ahemdabad"},
                new TraineeModel { Name = "Bob", Age = 30 , Address = "B-street ahemdabad"},
                new TraineeModel { Name = "Charlie", Age = 28, Address = "C-street ahemdabad"}
              
            };
        }

       

    }
}
