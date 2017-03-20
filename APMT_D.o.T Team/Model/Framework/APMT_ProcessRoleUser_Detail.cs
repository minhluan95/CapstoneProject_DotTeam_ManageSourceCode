namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_ProcessRoleUser_Detail
    {
        public int id { get; set; }

        public int process_role_id { get; set; }

        public int users_id { get; set; }

        public int running_process_detail_id { get; set; }

        public virtual APMT_Process_Role APMT_Process_Role { get; set; }

        public virtual APMT_Users APMT_Users { get; set; }
    }
}
