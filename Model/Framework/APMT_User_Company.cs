namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APMT_User_Company
    {
        public int id { get; set; }

        public int users_id { get; set; }

        public int company_id { get; set; }

        public virtual APMT_Company APMT_Company { get; set; }
    }
}
