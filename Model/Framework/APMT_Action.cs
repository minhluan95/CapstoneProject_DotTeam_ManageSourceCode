namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Action
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Action()
        {
            APMT_Permission = new HashSet<APMT_Permission>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ActionName { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(100)]
        public string ControllerName { get; set; }

        public virtual APMT_Controller APMT_Controller { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Permission> APMT_Permission { get; set; }
    }
}
