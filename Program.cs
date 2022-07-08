using SchoolProjectEntityFramework.Data;
using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolProjectContext();
            // ************************************************** //
            // Add
            /*   var student = new Student
               {
                   FirstName = "Maria",
                   LastName = "Dimitrova",
                   SSN = "980765367",
                   ClassLetter = new ClassLetter { Letter = "A"},
                   ClassNumber = new ClassNum { ClassNumber = "11" }
               };
               context.Student.Add(student);
               context.SaveChanges();*/

            /*  var student = new Student
              {
                  FirstName = "Dimitar",
                  LastName = "Ivanov",
                  SSN = "98887676",
                  ClassLetterId = 1,
                  ClassNumberId = 1
              };
              context.Student.Add(student);
              context.SaveChanges();*/

            /* var absence = new Absence
             {
                 Absences = 5
             };
             context.Absence.Add(absence);
             context.SaveChanges(); */
            /*
                        var teacher = new Teacher()
                        {
                            FirstName = "Iveta",
                            LastName = "Petrova",
                            SSN = "9865890"
                        };*/

            // ********************************************* //

            // Update
            /* var student = context.Student.Find(2);
             student.FirstName = "Peter";

             context.SaveChanges();*/

            // ********************************************* //

            // Remove

            var peter = context.Student.Find(2);
            context.Student.Remove(peter);

            context.SaveChanges();

        }
    }
}
