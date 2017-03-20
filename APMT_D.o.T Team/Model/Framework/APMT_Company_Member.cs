namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_Company_Member
    {
        public int id { get; set; }

        public int users_id { get; set; }

        public int company_id { get; set; }

        public int Company_Role_Id { get; set; }

        public virtual APMT_Company APMT_Company { get; set; }

        public virtual APMT_Users APMT_Users { get; set; }
    }
}
