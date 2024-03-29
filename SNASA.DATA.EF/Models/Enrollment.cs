﻿using System;
using System.Collections.Generic;

namespace SNASA.DATA.EF.Models
{
    public partial class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ScheduledClass? ScheduledClass { get; set; } 
        public virtual Student? Student { get; set; } 
    }
}
