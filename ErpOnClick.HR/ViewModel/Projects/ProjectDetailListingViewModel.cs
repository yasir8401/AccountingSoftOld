using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ErpOnClick.ErpMain.ViewModel
{
    public class ProjectDetailListingViewModel
    {
        public ErpOnClick.DAL.Models.Projects Project { get; set; }
        public string ProjectType { get; set; }
        public List<ErpOnClick.DAL.Models.Emp> TeamMembersList { get; set; }
        public string Status { get; set; }
        public string DaysBehidSchedule { get; set; }
        public ErpOnClick.DAL.Models.Emp ProjectManager { get; set; }
    }
}
