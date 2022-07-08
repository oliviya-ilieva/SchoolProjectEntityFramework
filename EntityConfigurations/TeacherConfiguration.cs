using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.EntityConfigurations
{
    public class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {




            public TeacherConfiguration()
            {

            HasMany(t => t.ClassesNumbers)
                .WithMany(c => c.Teachers)
            .Map(m =>
            {
                m.ToTable("TeacherClassNumbers");
                m.MapLeftKey("TeacherId");
                m.MapRightKey("ClassNumberId");
            });

            HasMany(t => t.ClassLetters)
               .WithMany(c => c.Teachers)
           .Map(m =>
           {
               m.MapLeftKey("TeacherId");
               m.MapRightKey("ClassLetterId");
           });

            HasMany(t => t.Absences)
             .WithMany(a => a.Teachers)
         .Map(m =>
         {
             m.MapLeftKey("TeacherId");
             m.MapRightKey("AbsenceId");
         });

            HasMany(t => t.Subjects)
               .WithMany(s => s.Teachers)
           .Map(m =>
           {
               m.ToTable("TeachersSubjects");
               m.MapLeftKey("TeacherId");
               m.MapRightKey("SubjectId");
           });

            HasMany(t => t.Grades)
              .WithMany(g => g.Teachers)
          .Map(m =>
          {
              m.ToTable("TeachersGrades");
              m.MapLeftKey("TeacherId");
              m.MapRightKey("GradeId");
          });


            Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);


                Property(t => t.SSN)
                    .IsRequired()
                    .HasMaxLength(100);

                HasMany(t => t.Addresses)
                  .WithRequired(a => a.Teacher)
                  .HasForeignKey(a => a.TeacherId)
                  .WillCascadeOnDelete(false);

                HasMany(t => t.Emails)
                 .WithRequired(e => e.Teacher)
                 .HasForeignKey(e => e.TeacherId)
                .WillCascadeOnDelete(false);

                HasMany(t => t.Phones)
                .WithRequired(p => p.Teacher)
                .HasForeignKey(p => p.TeacherId)
                .WillCascadeOnDelete(false);

            }

        }

    }

