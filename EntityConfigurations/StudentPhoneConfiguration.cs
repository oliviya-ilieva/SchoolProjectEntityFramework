using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.EntityConfigurations
{
    public class StudentPhoneConfiguration : EntityTypeConfiguration<StudentPhone>
    {
        public StudentPhoneConfiguration()

        {
            Property(s => s.PhoneNumber)
                   .HasMaxLength(50);

        }
    }
}
