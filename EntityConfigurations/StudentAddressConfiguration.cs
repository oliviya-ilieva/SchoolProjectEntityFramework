using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.EntityConfigurations
{
    public class StudentAddressConfiguration : EntityTypeConfiguration<StudentAddress>
    {
        public StudentAddressConfiguration()

        {
            Property(s => s.Address)
                   .HasMaxLength(80);

        }
    }
}
