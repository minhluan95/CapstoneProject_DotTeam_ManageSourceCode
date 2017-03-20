namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Files
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Files()
        {
            APMT_Activity = new HashSet<APMT_Activity>();
            APMT_Running_OutputActivity_upload = new HashSet<APMT_Running_OutputActivity_upload>();
            APMT_Running_Step_Input = new HashSet<APMT_Running_Step_Input>();
            APMT_Running_Step_Output = new HashSet<APMT_Running_Step_Output>();
            APMT_Step_Input = new HashSet<APMT_Step_Input>();
            APMT_Step_Output = new HashSet<APMT_Step_Output>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        public bool isdeliverable { get; set; }

        public int process_id { get; set; }

        public string descriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Activity> APMT_Activity { get; set; }

        public virtual APMT_Process APMT_Process { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_OutputActivity_upload> APMT_Running_OutputActivity_upload { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_Step_Input> APMT_Running_Step_Input { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_Step_Output> APMT_Running_Step_Output { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Step_Input> APMT_Step_Input { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Step_Output> APMT_Step_Output { get; set; }
    }
}
