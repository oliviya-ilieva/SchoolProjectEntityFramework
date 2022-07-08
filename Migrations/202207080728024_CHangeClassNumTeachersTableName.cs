namespace SchoolProjectEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CHangeClassNumTeachersTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ClassNumTeachers", newName: "TeacherClassNumbers");
            RenameColumn(table: "dbo.TeacherClassNumbers", name: "ClassNum_Id", newName: "ClassNumberId");
            RenameColumn(table: "dbo.TeacherClassNumbers", name: "Teacher_Id", newName: "TeacherId");
            RenameIndex(table: "dbo.TeacherClassNumbers", name: "IX_Teacher_Id", newName: "IX_TeacherId");
            RenameIndex(table: "dbo.TeacherClassNumbers", name: "IX_ClassNum_Id", newName: "IX_ClassNumberId");
            DropPrimaryKey("dbo.TeacherClassNumbers");
            AddPrimaryKey("dbo.TeacherClassNumbers", new[] { "TeacherId", "ClassNumberId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.TeacherClassNumbers");
            AddPrimaryKey("dbo.TeacherClassNumbers", new[] { "ClassNum_Id", "Teacher_Id" });
            RenameIndex(table: "dbo.TeacherClassNumbers", name: "IX_ClassNumberId", newName: "IX_ClassNum_Id");
            RenameIndex(table: "dbo.TeacherClassNumbers", name: "IX_TeacherId", newName: "IX_Teacher_Id");
            RenameColumn(table: "dbo.TeacherClassNumbers", name: "TeacherId", newName: "Teacher_Id");
            RenameColumn(table: "dbo.TeacherClassNumbers", name: "ClassNumberId", newName: "ClassNum_Id");
            RenameTable(name: "dbo.TeacherClassNumbers", newName: "ClassNumTeachers");
        }
    }
}
