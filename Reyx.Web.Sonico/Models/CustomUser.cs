using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Reyx.Web.Sonico.Models
{
    [NotMapped]
    public class CustomUser : MembershipUser
    {
        public CustomUser(string providername, User userAccount)
            : base(providername,
                        userAccount.UserName,
                        userAccount.Id,
                        userAccount.Email,
                        "",
                        string.Empty,
                        true,
                        false,
                        userAccount.CreationDate,
                        userAccount.LastLoginDate ?? userAccount.CreationDate,
                        userAccount.LastActivityDate ?? userAccount.CreationDate,
                        new DateTime(),
                        new DateTime())
        {
            this.UserAccount = userAccount;
        }

        public User UserAccount { get;  set; }
    }
}