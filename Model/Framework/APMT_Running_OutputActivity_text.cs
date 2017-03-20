namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Running_OutputActivity_text
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Timestamps { get; set; }

        [Required]
        public string contents { get; set; }

        public int running_activity_detail_id { get; set; }

        public virtual APMT_Running_Activity_Detail APMT_Running_Activity_Detail { get; set; }
    }
}
