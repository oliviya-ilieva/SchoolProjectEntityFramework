using FluentValidation;
using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.AbstractValidator
{
    public class StudentEmailValidation : AbstractValidator<StudentEmailAddress>
    {
        public StudentEmailValidation()
        {
            RuleFor(s => s.EmailAddress).EmailAddress();
        }
    }
}
