namespace SchoolProjectEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStudentAddressColumn1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentEmailAddresses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentPhones", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentEmailAddresses", new[] { "Student_Id" });
            DropIndex("dbo.StudentPhones", new[] { "Student_Id" });
            RenameColumn(table: "dbo.StudentEmailAddresses", name: "Student_Id", newName: "StudentId");
            RenameColumn(table: "dbo.StudentPhones", name: "Student_Id", newName: "StudentId");
            AlterColumn("dbo.StudentEmailAddresses", "StudentId", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentPhones", "StudentId", c => c.Int(nullable: false));
            CreateIndex("dbo.StudentEmailAddresses", "StudentId");
            CreateIndex("dbo.StudentPhones", "StudentId");
            AddForeignKey("dbo.StudentEmailAddresses", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentPhones", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentPhones", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentEmailAddresses", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentPhones", new[] { "StudentId" });
            DropIndex("dbo.StudentEmailAddresses", new[] { "StudentId" });
            AlterColumn("dbo.StudentPhones", "StudentId", c => c.Int());
            AlterColumn("dbo.StudentEmailAddresses", "StudentId", c => c.Int());
            RenameColumn(table: "dbo.StudentPhones", name: "StudentId", newName: "Student_Id");
            RenameColumn(table: "dbo.StudentEmailAddresses", name: "StudentId", newName: "Student_Id");
            CreateIndex("dbo.StudentPhones", "Student_Id");
            CreateIndex("dbo.StudentEmailAddresses", "Student_Id");
            AddForeignKey("dbo.StudentPhones", "Student_Id", "dbo.Students", "Id");
            AddForeignKey("dbo.StudentEmailAddresses", "Student_Id", "dbo.Students", "Id");
        }
    }
}
