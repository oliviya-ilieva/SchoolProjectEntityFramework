using FluentValidation;
using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.AbstractValidator
{
    public class GradeValidation : AbstractValidator<Grade>
    {
        public GradeValidation()
        {
            RuleFor(g => g.Grades).InclusiveBetween(2, 6);
        }

    }
}
