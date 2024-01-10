using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.Approvals.Models
{
    public class ApprovalRouteDetailViewModel
    {
        public string ApprovarUser { get; set; }
        public string Status { get; set; }
        public string RequestedBy { get; set; }
        public RequestDetails RequestDetail { get; set; }
        public ApprovalRoutesDetail Route { get; set; }
        public List<ApprovalUser> ApproverUsersList { get; set; }



    }
    public class ApprovalUser
    {
        public string UserName { get; set; }
        public string Status { get; set; }
    }
    public class RequestDetails
    {
        public string Date { get; set; }
        public string RequestStatus { get; set; }
    }

}
