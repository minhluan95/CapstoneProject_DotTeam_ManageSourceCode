namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Running_OutputActivity_refer
    {
        public int id { get; set; }

        public int Activity_output_Refer_id { get; set; }

        public int process_id { get; set; }

        public virtual APMT_Activity APMT_Activity { get; set; }
    }
}
