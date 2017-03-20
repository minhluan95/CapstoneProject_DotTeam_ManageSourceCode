namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Activity
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? Process_Id { get; set; }

        public int? Weigth { get; set; }

        [StringLength(2)]
        public string Type { get; set; }

        public virtual APMT_Process APMT_Process { get; set; }
    }
}
