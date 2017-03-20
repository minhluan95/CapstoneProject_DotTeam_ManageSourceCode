namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Project()
        {
            APMT_Running_Process_Detail = new HashSet<APMT_Running_Process_Detail>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        public string Descriptions { get; set; }

        public int manager_id { get; set; }

        public int company_id { get; set; }

        [Required]
        [StringLength(200)]
        public string status { get; set; }

        public virtual APMT_Company APMT_Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_Process_Detail> APMT_Running_Process_Detail { get; set; }

        public virtual APMT_Users APMT_Users { get; set; }
    }
}
