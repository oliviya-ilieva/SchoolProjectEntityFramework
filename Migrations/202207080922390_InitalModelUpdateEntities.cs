namespace SchoolProjectEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalModelUpdateEntities : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentAddresses", "Address", c => c.String(maxLength: 80));
            AlterColumn("dbo.ClassLetters", "Letter", c => c.String(maxLength: 20));
            AlterColumn("dbo.TeacherAddresses", "Address", c => c.String(maxLength: 80));
            AlterColumn("dbo.ClassNums", "ClassNumber", c => c.String(maxLength: 20));
            AlterColumn("dbo.TeacherEmailAddresses", "EmailAddress", c => c.String(maxLength: 80));
            AlterColumn("dbo.TeacherPhones", "PhoneNumber", c => c.String(maxLength: 80));
            AlterColumn("dbo.Subjects", "SubjectName", c => c.String(maxLength: 100));
            AlterColumn("dbo.StudentEmailAddresses", "EmailAddress", c => c.String(maxLength: 80));
            AlterColumn("dbo.StudentPhones", "PhoneNumber", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentPhones", "PhoneNumber", c => c.String());
            AlterColumn("dbo.StudentEmailAddresses", "EmailAddress", c => c.String());
            AlterColumn("dbo.Subjects", "SubjectName", c => c.String());
            AlterColumn("dbo.TeacherPhones", "PhoneNumber", c => c.String());
            AlterColumn("dbo.TeacherEmailAddresses", "EmailAddress", c => c.String());
            AlterColumn("dbo.ClassNums", "ClassNumber", c => c.String());
            AlterColumn("dbo.TeacherAddresses", "Address", c => c.String());
            AlterColumn("dbo.ClassLetters", "Letter", c => c.String());
            AlterColumn("dbo.StudentAddresses", "Address", c => c.String());
        }
    }
}
