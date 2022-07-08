using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string SSN { get; set; }

        public List<TeacherAddress> Addresses { get; set; } 
        public List<TeacherPhone> Phones { get; set; } 
        public List<TeacherEmailAddress> Emails { get; set; }
        public List<Absence> Absences { get; set; } 
        public List<Grade> Grades { get; set; } 

        public List<Subject> Subjects { get; set; }
        public List<ClassLetter> ClassLetters { get; set; } 
        public List<ClassNum> ClassesNumbers { get; set; } 
    }
}
