using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class OverTimeSettingAndDetailViewModel
    {
        public OvertimeSettings OvertimeSettings { get; set; }
        public IList<ErpOnClick.DAL.Models.OvertimeSettingsDetail>  OvertimeSettingsDetails { get; set; }
    }
}
