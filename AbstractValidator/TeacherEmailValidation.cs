using FluentValidation;
using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.AbstractValidator
{
    public class TeacherEmailValidation : AbstractValidator<TeacherEmailAddress>
    {
        public TeacherEmailValidation()
        {
            RuleFor(s => s.EmailAddress).EmailAddress();
        }
    }
}
