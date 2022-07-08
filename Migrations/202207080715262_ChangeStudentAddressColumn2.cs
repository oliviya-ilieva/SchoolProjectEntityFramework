namespace SchoolProjectEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStudentAddressColumn2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "ClassLetterId", "dbo.ClassLetters");
            DropForeignKey("dbo.Students", "ClassNumberId", "dbo.ClassNums");
            DropForeignKey("dbo.StudentEmailAddresses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentPhones", "StudentId", "dbo.Students");
            AddForeignKey("dbo.StudentAddresses", "StudentId", "dbo.Students", "Id");
            AddForeignKey("dbo.Students", "ClassLetterId", "dbo.ClassLetters", "Id");
            AddForeignKey("dbo.Students", "ClassNumberId", "dbo.ClassNums", "Id");
            AddForeignKey("dbo.StudentEmailAddresses", "StudentId", "dbo.Students", "Id");
            AddForeignKey("dbo.StudentPhones", "StudentId", "dbo.Students", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentPhones", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentEmailAddresses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "ClassNumberId", "dbo.ClassNums");
            DropForeignKey("dbo.Students", "ClassLetterId", "dbo.ClassLetters");
            DropForeignKey("dbo.StudentAddresses", "StudentId", "dbo.Students");
            AddForeignKey("dbo.StudentPhones", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentEmailAddresses", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Students", "ClassNumberId", "dbo.ClassNums", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Students", "ClassLetterId", "dbo.ClassLetters", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentAddresses", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
