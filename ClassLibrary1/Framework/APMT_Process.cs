namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Process
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Process()
        {
            APMT_Activity = new HashSet<APMT_Activity>();
            APMT_Process_Role = new HashSet<APMT_Process_Role>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public string JsonContent { get; set; }

        public string Description { get; set; }

        public int? Creator_Id { get; set; }

        public bool? Allowed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Activity> APMT_Activity { get; set; }

        public virtual APMT_Company_User APMT_Company_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Process_Role> APMT_Process_Role { get; set; }
    }
}
