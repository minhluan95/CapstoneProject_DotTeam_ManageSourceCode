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
    
    public partial class APMT_Step_Role
    {
        public int id { get; set; }
        public int step_id { get; set; }
        public int role_id { get; set; }
    
        public virtual APMT_Process_Role APMT_Process_Role { get; set; }
        public virtual APMT_Step APMT_Step { get; set; }
    }
}
