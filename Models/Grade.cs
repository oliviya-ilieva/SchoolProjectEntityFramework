using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.Models
{
    public class Grade
    {
        public int Id { get; set; }
    public int Grades { get; set; }
    public List<Teacher> Teachers  { get; set; }
        public List<Student> Students { get; set; }
    }
}
