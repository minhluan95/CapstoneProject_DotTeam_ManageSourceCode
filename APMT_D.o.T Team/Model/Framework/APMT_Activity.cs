namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Activity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Activity()
        {
            APMT_Running_Activity_Detail = new HashSet<APMT_Running_Activity_Detail>();
            APMT_Running_OutputActivity_refer = new HashSet<APMT_Running_OutputActivity_refer>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        public string descriptions { get; set; }

        public int step_id { get; set; }

        public int weights { get; set; }

        public int predecessor { get; set; }

        public int type_output_id { get; set; }

        public int? process_id { get; set; }

        public int? files_id { get; set; }

        [StringLength(200)]
        public string title { get; set; }

        public virtual APMT_Files APMT_Files { get; set; }

        public virtual APMT_Step APMT_Step { get; set; }

        public virtual APMT_Type_Output APMT_Type_Output { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_Activity_Detail> APMT_Running_Activity_Detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_OutputActivity_refer> APMT_Running_OutputActivity_refer { get; set; }
    }
}
