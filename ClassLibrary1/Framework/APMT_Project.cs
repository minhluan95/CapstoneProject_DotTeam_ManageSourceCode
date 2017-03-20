namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Project
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? Manager_Id { get; set; }

        public int? Company_Id { get; set; }

        public bool? Allowed { get; set; }

        public virtual APMT_Company APMT_Company { get; set; }

        public virtual APMT_Company_User APMT_Company_User { get; set; }
    }
}
