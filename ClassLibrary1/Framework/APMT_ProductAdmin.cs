namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_ProductAdmin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_ProductAdmin()
        {
            APMT_Permission = new HashSet<APMT_Permission>();
        }

        [Key]
        public int UserId { get; set; }

        [StringLength(64)]
        public string Username { get; set; }

        [StringLength(256)]
        public string Password { get; set; }

        [StringLength(64)]
        public string FullName { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(500)]
        public string Avatar { get; set; }

        public int? isAdmin { get; set; }

        public int? Allowed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Permission> APMT_Permission { get; set; }
    }
}
