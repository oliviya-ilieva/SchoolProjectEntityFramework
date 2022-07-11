using SchoolProjectEntityFramework.AbstractValidator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new StudentEmailValidation();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}
