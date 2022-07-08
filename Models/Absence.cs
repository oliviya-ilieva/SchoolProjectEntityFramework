using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.Models
{
    public class Absence
    {
        public int Id { get; set; }
        public int Absences { get; set; }

        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
