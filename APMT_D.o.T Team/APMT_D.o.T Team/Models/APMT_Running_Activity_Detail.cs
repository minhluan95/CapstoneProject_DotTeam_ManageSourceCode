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
    
    public partial class APMT_Running_Activity_Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Running_Activity_Detail()
        {
            this.APMT_Comment = new HashSet<APMT_Comment>();
            this.APMT_Running_OutputActivity_text = new HashSet<APMT_Running_OutputActivity_text>();
            this.APMT_Running_OutputActivity_upload = new HashSet<APMT_Running_OutputActivity_upload>();
        }
    
        public int id { get; set; }
        public int Activity_id { get; set; }
        public int Member_id { get; set; }
        public int Running_Step_Detail_id { get; set; }
        public int Activity_Status_id { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
    
        public virtual APMT_Activity APMT_Activity { get; set; }
        public virtual APMT_Activity_Status APMT_Activity_Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Comment> APMT_Comment { get; set; }
        public virtual APMT_Users APMT_Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_OutputActivity_text> APMT_Running_OutputActivity_text { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_OutputActivity_upload> APMT_Running_OutputActivity_upload { get; set; }
    }
}
