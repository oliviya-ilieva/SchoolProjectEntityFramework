namespace SchoolProjectEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalModelUpdateEntities1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.StudentAbsences", name: "Student_Id", newName: "StudentId");
            RenameColumn(table: "dbo.StudentAbsences", name: "Absence_Id", newName: "AbsenceId");
            RenameIndex(table: "dbo.StudentAbsences", name: "IX_Student_Id", newName: "IX_StudentId");
            RenameIndex(table: "dbo.StudentAbsences", name: "IX_Absence_Id", newName: "IX_AbsenceId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.StudentAbsences", name: "IX_AbsenceId", newName: "IX_Absence_Id");
            RenameIndex(table: "dbo.StudentAbsences", name: "IX_StudentId", newName: "IX_Student_Id");
            RenameColumn(table: "dbo.StudentAbsences", name: "AbsenceId", newName: "Absence_Id");
            RenameColumn(table: "dbo.StudentAbsences", name: "StudentId", newName: "Student_Id");
        }
    }
}
