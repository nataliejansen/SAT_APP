﻿using System;
using System.Collections.Generic;

namespace SNASA.DATA.EF.Models
{
    public partial class ScheduledClassStatus
    {
        public ScheduledClassStatus()
        {
            ScheduledClasses = new HashSet<ScheduledClass>();
        }

        public int Scsid { get; set; }
        public string Scsname { get; set; } = null!;

        public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }
    }
}
