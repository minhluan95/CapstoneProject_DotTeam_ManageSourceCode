namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Running_Step_Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Running_Step_Detail()
        {
            APMT_Running_Step_Input = new HashSet<APMT_Running_Step_Input>();
            APMT_Running_Step_Output = new HashSet<APMT_Running_Step_Output>();
        }

        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime TargetDate { get; set; }

        public int step_id { get; set; }

        public int Running_Process_Detail_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_Step_Input> APMT_Running_Step_Input { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_Step_Output> APMT_Running_Step_Output { get; set; }
    }
}
