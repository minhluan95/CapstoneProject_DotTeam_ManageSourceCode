namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Step_Output
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Step_Output()
        {
            APMT_Running_Step_Output = new HashSet<APMT_Running_Step_Output>();
        }

        public int id { get; set; }

        public int Files_id { get; set; }

        public int Step_id { get; set; }

        public virtual APMT_Files APMT_Files { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_Step_Output> APMT_Running_Step_Output { get; set; }

        public virtual APMT_Step APMT_Step { get; set; }
    }
}
