using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.EntityConfigurations
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {


       


        public StudentConfiguration() {

            ToTable("Students");

            Property(s => s.FirstName)
            .IsRequired()
            .HasMaxLength(50);


            Property(s => s.SSN)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(s => s.ClassLetter)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassLetterId)
                .WillCascadeOnDelete(false);

            HasRequired(s => s.ClassNumber)
              .WithMany(c => c.Students)
              .HasForeignKey(s => s.ClassNumberId)
              .WillCascadeOnDelete(false);

            HasMany(s => s.Grades)
         .WithMany(g => g.Students)
          .Map(m =>
     {
         m.ToTable("StudentsGrades");
         m.MapLeftKey("StudentId");
         m.MapRightKey("GradeId");
     });

            HasMany(s => s.Absences)
    .WithMany(a => a.Students)
     .Map(m =>
     {
       
         m.MapLeftKey("StudentId");
         m.MapRightKey("AbsenceId");
     });


            HasMany(t => t.Subjects)
        .WithMany(s => s.Students)
         .Map(m =>
    {
        m.ToTable("StudentsSubjects");
        m.MapLeftKey("StudentId");
        m.MapRightKey("SubjectId");
    });

            HasMany(s => s.Addresses)
              .WithRequired(a => a.Student)
              .HasForeignKey(a => a.StudentId)
              .WillCascadeOnDelete(false);

            HasMany(s => s.EmailAddresses)
             .WithRequired(e => e.Student)
             .HasForeignKey(e=> e.StudentId)
            .WillCascadeOnDelete(false);

            HasMany(s => s.Phones)
            .WithRequired(p => p.Student)
            .HasForeignKey(p => p.StudentId)
            .WillCascadeOnDelete(false);

        }

    }
    
}
