using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.EntityConfigurations
{
    public class ClassLetterConfiguration : EntityTypeConfiguration<ClassLetter>
    {
        public ClassLetterConfiguration()

        {
            Property(c => c.Letter)
                   .HasMaxLength(20);
                    

        }
    }
}
