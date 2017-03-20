namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Process_Role
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Process_Id { get; set; }

        public virtual APMT_Process APMT_Process { get; set; }
    }
}
