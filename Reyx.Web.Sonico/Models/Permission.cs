using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reyx.Web.Sonico.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int TaskId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Task Task { get; set; }
    }
}