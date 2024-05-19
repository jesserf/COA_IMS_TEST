using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_IMS.Screens.Subscrn.Tracking
{
    public class TrackingDTO
    {
        public string ics_number { get; set; }
        public string entity_name { get; set; }
        public int entity_id { get; set; }
        public string fund_cluster { get; set; }
        public string received_by { get; set; }
        public int received_by_id { get; set; }
        public string received_from { get; set; }
        public int received_from_id { get; set; }
        public string emp_position { get; set; }
        public string emp_office { get; set; }
        public DataTable items { get; set; }
    }
}
