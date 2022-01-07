using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdkFollowizeNet.Models
{
    public class LeadResult
    {
        public string success { get; set; }
        public string error { get; set; }
        public string leadId { get; set; }
        public string leadType { get; set; }
    }
}
