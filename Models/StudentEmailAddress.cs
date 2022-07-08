﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.Models
{
    public class StudentEmailAddress
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }

        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
