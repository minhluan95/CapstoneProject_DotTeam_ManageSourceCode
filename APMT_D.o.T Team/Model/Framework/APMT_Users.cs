namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APMT_Users()
        {
            APMT_Company_Member = new HashSet<APMT_Company_Member>();
            APMT_Process = new HashSet<APMT_Process>();
            APMT_ProcessRoleUser_Detail = new HashSet<APMT_ProcessRoleUser_Detail>();
            APMT_Project = new HashSet<APMT_Project>();
            APMT_Running_Activity_Detail = new HashSet<APMT_Running_Activity_Detail>();
            APMT_Running_Process_Detail = new HashSet<APMT_Running_Process_Detail>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Passwords { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string Statuss { get; set; }

        public int? IDRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Company_Member> APMT_Company_Member { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Process> APMT_Process { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_ProcessRoleUser_Detail> APMT_ProcessRoleUser_Detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Project> APMT_Project { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_Activity_Detail> APMT_Running_Activity_Detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APMT_Running_Process_Detail> APMT_Running_Process_Detail { get; set; }

        public virtual Company_Role Company_Role { get; set; }
    }
}
