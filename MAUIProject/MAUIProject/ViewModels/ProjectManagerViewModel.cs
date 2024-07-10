using MAUIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIProject.ViewModels
{
    public class ProjectManagerViewModel
    {
        public List<ProjectManagerModel> ProjectManager { get; set; }
        public ProjectManagerViewModel()
        {
            ProjectManager = new List<ProjectManagerModel>()
            {
                new ProjectManagerModel { Name = "Shreya", Salary = 150000 },
                new ProjectManagerModel { Name = "Priti", Salary = 100000 },
               

            };
        }
    }
}
