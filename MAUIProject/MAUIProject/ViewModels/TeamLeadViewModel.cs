// TeamLeadViewModel.cs
using MAUIProject.Models;
using System.Collections.Generic;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using MAUIProject.Views;

namespace MAUIProject.ViewModels
{
    public class TeamLeadViewModel
    {
        public List<TeamLeadModel> TeamLead { get; set; }
        public TeamLeadViewModel()
        {
            TeamLead = new List<TeamLeadModel>()
            {
                new TeamLeadModel { Name = "Hima", NoOfTeams = 3, Salary = 70000 },
                new TeamLeadModel { Name = "Rahul", NoOfTeams = 2, Salary = 65000 },
                new TeamLeadModel { Name = "Dezy", NoOfTeams = 1, Salary = 64000}
            };

            
        }
    }
}
