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
    
    public partial class APMT_Running_OutputActivity_refer
    {
        public int id { get; set; }
        public int Activity_output_Refer_id { get; set; }
        public int process_id { get; set; }
    
        public virtual APMT_Activity APMT_Activity { get; set; }
    }
}