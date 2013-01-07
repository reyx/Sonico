using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reyx.Web.Sonico.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
    }
}