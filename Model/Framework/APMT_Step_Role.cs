namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Step_Role
    {
        public int id { get; set; }

        public int step_id { get; set; }

        public int role_id { get; set; }

        public virtual APMT_Process_Role APMT_Process_Role { get; set; }

        public virtual APMT_Step APMT_Step { get; set; }
    }
}
