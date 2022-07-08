using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.EntityConfigurations
{
    public class ClassNumConfiguration : EntityTypeConfiguration<ClassNum>
    {
        public ClassNumConfiguration()

        {
            Property(c => c.ClassNumber)
                   .HasMaxLength(20);

        }
    }
}
