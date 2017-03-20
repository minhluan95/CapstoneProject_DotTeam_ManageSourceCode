namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Timeline
    {
        public int id { get; set; }

        public int Running_Process_Detail_id { get; set; }

        [Required]
        public string Contents { get; set; }

        public virtual APMT_Running_Process_Detail APMT_Running_Process_Detail { get; set; }
    }
}
