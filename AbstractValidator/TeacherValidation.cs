using FluentValidation;
using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.AbstractValidator
{
    public class TeacherValidation : AbstractValidator<Teacher>
    {
        public TeacherValidation()
        {
            RuleFor(s => s.FirstName).NotEmpty().Length(0, 20).Matches("^[A-Z][a-zA-Z]*$").WithMessage("First name cannot be more than 20 characters");
            RuleFor(s => s.LastName).NotEmpty().Length(0, 20).Matches("^[A-Z][a-zA-Z]*$").WithMessage("Last name cannot be more than 20 characters");
        }
    }
}
