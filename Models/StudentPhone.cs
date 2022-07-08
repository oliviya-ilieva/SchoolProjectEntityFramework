using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.Models
{
    public class StudentPhone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
