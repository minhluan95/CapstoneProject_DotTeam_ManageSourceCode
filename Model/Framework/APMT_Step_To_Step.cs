namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Step_To_Step
    {
        public int id { get; set; }

        public int fromStep_id { get; set; }

        public int toStep_id { get; set; }

        public virtual APMT_Step APMT_Step { get; set; }

        public virtual APMT_Step APMT_Step1 { get; set; }
    }
}
