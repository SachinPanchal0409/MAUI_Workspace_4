using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIProject.Models
{
    public class SEModel : EmployeeBaseModel
    {
        public string ProjectName { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
    }
}
