using SchoolProjectEntityFramework.AbstractValidator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.Models
{
    public class TeacherEmailAddress
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new TeacherEmailValidation();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}
