using MAUIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIProject.ViewModels
{
    public class SeniorTeamLeadViewModel
    {
        public List<SeniorTeamLeadModel> SeniorTeamLead { get; set; }
        public SeniorTeamLeadViewModel()
        {
            SeniorTeamLead = new List<SeniorTeamLeadModel>()
            {
                new SeniorTeamLeadModel { Name = "Ishita", NoOfTeams = 4, Salary = 100000 },
                new SeniorTeamLeadModel { Name = "Rohan", NoOfTeams = 3, Salary = 80000 },
                new SeniorTeamLeadModel { Name = "Tipsi", NoOfTeams = 2, Salary = 90000}

            };
        }
    }
}
