using SchoolProjectEntityFramework.EntityConfigurations;
using SchoolProjectEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectEntityFramework.Data
{

    public class SchoolProjectContext : DbContext
    {
        public DbSet<Student> Student { get; set; } 
        public DbSet<StudentAddress> StudentAddress { get; set; } 
        public DbSet<StudentEmailAddress> StudentEmailAddress { get; set; } 
        public DbSet<StudentPhone> StudentPhone { get; set; } 
        public DbSet<Absence> Absence { get; set; } 
        public DbSet<Grade> Grade { get; set; } 
        public DbSet<Subject> Subject { get; set; } 
        public DbSet<Teacher> Teacher { get; set; } 
        public DbSet<TeacherEmailAddress> TeacherEmailAddress { get; set; } 
        public DbSet<TeacherPhone> TeacherPhone { get; set; } 
        public DbSet<TeacherAddress> TeacherAddress { get; set; } 

        public DbSet<ClassLetter> ClassLetter { get; set; } 
        public DbSet<ClassNum> ClassNumber { get; set; } 

        public SchoolProjectContext() : base("name=DefaultConnection")
        {

        }

       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new TeacherConfiguration());
            modelBuilder.Configurations.Add(new ClassLetterConfiguration());
            modelBuilder.Configurations.Add(new ClassNumConfiguration());
            modelBuilder.Configurations.Add(new StudentAddressConfiguration());
            modelBuilder.Configurations.Add(new StudentEmailAddressConfiguration());
            modelBuilder.Configurations.Add(new StudentPhoneConfiguration());
            modelBuilder.Configurations.Add(new SubjectConfiguration());
            modelBuilder.Configurations.Add(new TeacherAddressConfiguration());
            modelBuilder.Configurations.Add(new TeacherEmailAddressConfiguration());
            modelBuilder.Configurations.Add(new TeacherPhoneConfiguration());
            

        }



    }
}
