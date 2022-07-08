using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.Models
{
    public class TeacherPhone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }

        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
    }
}
