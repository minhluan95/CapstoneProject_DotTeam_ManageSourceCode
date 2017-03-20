namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Company()
        {
            APMT_Company_User = new HashSet<APMT_Company_User>();
            APMT_Project = new HashSet<APMT_Project>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Admin_id { get; set; }

        public bool? Allowed { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Register_at { get; set; }

        public virtual APMT_User APMT_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Company_User> APMT_Company_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Project> APMT_Project { get; set; }
    }
}
