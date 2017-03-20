using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APMT_D.o.T_Team.Areas.Company.Models
{
    public class lstProcess_Running
    {
        public String name_project { get; set; }
        public String name_process { get; set; }
        public String email_admin { get; set; }
        public DateTime process_targetdate { get; set; }
    }
}