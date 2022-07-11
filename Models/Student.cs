using SchoolProjectEntityFramework.AbstractValidator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.Models
{
    public class Student : IValidatableObject
    {
       
            public int Id { get; set; }
            public string FirstName { get; set; } 
            public string LastName { get; set; }
            public string SSN { get; set; } 
            public ClassLetter ClassLetter { get; set; } 
            public ClassNum ClassNumber { get; set; } 
            public int ClassLetterId { get; set; }
            public int ClassNumberId { get; set; }
           
            public List<StudentAddress> Addresses { get; set; } 
            public List<StudentEmailAddress> EmailAddresses { get; set; } 
            public List<StudentPhone> Phones { get; set; } 
            public List<Absence> Absences { get; set; } 
            public List<Grade> Grades { get; set; }
        public List<Subject> Subjects { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new StudentValidation();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}
