namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Step
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Step()
        {
            APMT_Activity = new HashSet<APMT_Activity>();
            APMT_Step_Input = new HashSet<APMT_Step_Input>();
            APMT_Step_Output = new HashSet<APMT_Step_Output>();
            APMT_Step_Role = new HashSet<APMT_Step_Role>();
            APMT_Step_To_Step = new HashSet<APMT_Step_To_Step>();
            APMT_Step_To_Step1 = new HashSet<APMT_Step_To_Step>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        public string descriptions { get; set; }

        public int process_id { get; set; }

        public int weights { get; set; }

        [Required]
        [StringLength(200)]
        public string typess { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Activity> APMT_Activity { get; set; }

        public virtual APMT_Process APMT_Process { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Step_Input> APMT_Step_Input { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Step_Output> APMT_Step_Output { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Step_Role> APMT_Step_Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Step_To_Step> APMT_Step_To_Step { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Step_To_Step> APMT_Step_To_Step1 { get; set; }
    }
}
