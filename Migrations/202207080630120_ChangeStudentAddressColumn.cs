namespace SchoolProjectEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStudentAddressColumn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentAddresses", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "Student_Id" });
            RenameColumn(table: "dbo.StudentAddresses", name: "Student_Id", newName: "StudentId");
            AlterColumn("dbo.StudentAddresses", "StudentId", c => c.Int(nullable: false));
            CreateIndex("dbo.StudentAddresses", "StudentId");
            AddForeignKey("dbo.StudentAddresses", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "StudentId" });
            AlterColumn("dbo.StudentAddresses", "StudentId", c => c.Int());
            RenameColumn(table: "dbo.StudentAddresses", name: "StudentId", newName: "Student_Id");
            CreateIndex("dbo.StudentAddresses", "Student_Id");
            AddForeignKey("dbo.StudentAddresses", "Student_Id", "dbo.Students", "Id");
        }
    }
}
