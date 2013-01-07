using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reyx.Web.Sonico.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ModuleId { get; set; }

        public virtual Module Module { get; set; }
    }
}