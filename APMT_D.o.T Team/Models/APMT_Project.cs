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
    
    public partial class APMT_Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Project()
        {
            this.APMT_Running_Process_Detail = new HashSet<APMT_Running_Process_Detail>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string Descriptions { get; set; }
        public int manager_id { get; set; }
        public int company_id { get; set; }
        public string status { get; set; }
    
        public virtual APMT_Company APMT_Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_Process_Detail> APMT_Running_Process_Detail { get; set; }
        public virtual APMT_Users APMT_Users { get; set; }
    }
}
