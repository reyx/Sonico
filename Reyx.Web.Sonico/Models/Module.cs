﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reyx.Web.Sonico.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string Path { get; set; }
        public bool Enabled { get; set; }
    }
}