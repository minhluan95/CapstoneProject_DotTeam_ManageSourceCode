using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APMT_D.o.T_Team.Areas.User.Models
{
    public class LoginModel
    {
        [Required]
        public string Email { set; get; }
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}