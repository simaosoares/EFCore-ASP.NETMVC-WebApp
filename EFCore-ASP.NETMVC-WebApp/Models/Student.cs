﻿using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    /// <summary>
    /// The ID property will become the primary key column of the database table that corresponds to this class. 
    /// By default, the Entity Framework interprets a property that's named ID or classnameID as the primary key.
    /// </summary>
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}