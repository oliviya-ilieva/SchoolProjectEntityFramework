using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.EntityConfigurations
{
    public class SubjectConfiguration : EntityTypeConfiguration<Subject>
    {
        public SubjectConfiguration()

        {
            Property(s => s.SubjectName)
                   .HasMaxLength(100);

        }
    }
}
