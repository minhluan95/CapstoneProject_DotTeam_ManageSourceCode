namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Company_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Company_User()
        {
            APMT_Process = new HashSet<APMT_Process>();
            APMT_Project = new HashSet<APMT_Project>();
        }

        public int ID { get; set; }

        public int? Company_id { get; set; }

        public int? User_id { get; set; }

        public virtual APMT_Company APMT_Company { get; set; }

        public virtual APMT_User APMT_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Process> APMT_Process { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Project> APMT_Project { get; set; }
    }
}
