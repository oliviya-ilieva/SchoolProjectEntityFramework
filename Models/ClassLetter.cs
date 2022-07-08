using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.Models
{
    public class ClassLetter
    {
        public int Id { get; set; }

       
        public string Letter { get; set; }

        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
    }
}
