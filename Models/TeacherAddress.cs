using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.Models
{
    public class TeacherAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
    }
}
