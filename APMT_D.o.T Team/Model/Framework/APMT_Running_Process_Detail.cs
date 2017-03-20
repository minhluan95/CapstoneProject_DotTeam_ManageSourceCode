namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Running_Process_Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Running_Process_Detail()
        {
            APMT_Timeline = new HashSet<APMT_Timeline>();
        }

        public int id { get; set; }

        public int process_id { get; set; }

        public int leader_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime targetdate { get; set; }

        public int project_id { get; set; }

        public virtual APMT_Project APMT_Project { get; set; }

        public virtual APMT_Users APMT_Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Timeline> APMT_Timeline { get; set; }
    }
}
