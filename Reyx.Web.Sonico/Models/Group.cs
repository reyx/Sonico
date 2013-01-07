using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reyx.Web.Sonico.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Readonly { get; set; }
        public bool Enabled { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}