//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APMT_D.o.T_Team.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class APMT_Running_Step_Input
    {
        public int id { get; set; }
        public string Versions { get; set; }
        public string URL { get; set; }
        public System.DateTime Timestamps { get; set; }
        public int Files_id { get; set; }
        public int running_step_detail_id { get; set; }
        public int Step_Input_id { get; set; }
    
        public virtual APMT_Files APMT_Files { get; set; }
        public virtual APMT_Running_Step_Detail APMT_Running_Step_Detail { get; set; }
        public virtual APMT_Step_Input APMT_Step_Input { get; set; }
    }
}
