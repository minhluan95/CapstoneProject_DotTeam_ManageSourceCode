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
    
    public partial class APMT_Running_OutputActivity_text
    {
        public int id { get; set; }
        public System.DateTime Timestamps { get; set; }
        public string contents { get; set; }
        public int running_activity_detail_id { get; set; }
    
        public virtual APMT_Running_Activity_Detail APMT_Running_Activity_Detail { get; set; }
    }
}