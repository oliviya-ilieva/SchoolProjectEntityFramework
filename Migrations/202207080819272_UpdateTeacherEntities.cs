namespace SchoolProjectEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTeacherEntities : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SubjectTeachers", newName: "TeachersSubjects");
            DropIndex("dbo.TeacherAddresses", new[] { "Teacher_Id" });
            DropIndex("dbo.TeacherEmailAddresses", new[] { "Teacher_Id" });
            DropIndex("dbo.TeacherPhones", new[] { "Teacher_Id" });
            RenameColumn(table: "dbo.TeacherAbsences", name: "Teacher_Id", newName: "TeacherId");
            RenameColumn(table: "dbo.TeacherAbsences", name: "Absence_Id", newName: "AbsenceId");
            RenameColumn(table: "dbo.TeacherClassLetters", name: "Teacher_Id", newName: "TeacherId");
            RenameColumn(table: "dbo.TeacherClassLetters", name: "ClassLetter_Id", newName: "ClassLetterId");
            RenameColumn(table: "dbo.TeacherAddresses", name: "Teacher_Id", newName: "TeacherId");
            RenameColumn(table: "dbo.TeacherEmailAddresses", name: "Teacher_Id", newName: "TeacherId");
            RenameColumn(table: "dbo.TeacherPhones", name: "Teacher_Id", newName: "TeacherId");
            RenameColumn(table: "dbo.TeachersSubjects", name: "Subject_Id", newName: "SubjectId");
            RenameColumn(table: "dbo.TeachersSubjects", name: "Teacher_Id", newName: "TeacherId");
            RenameIndex(table: "dbo.TeacherAbsences", name: "IX_Teacher_Id", newName: "IX_TeacherId");
            RenameIndex(table: "dbo.TeacherAbsences", name: "IX_Absence_Id", newName: "IX_AbsenceId");
            RenameIndex(table: "dbo.TeacherClassLetters", name: "IX_Teacher_Id", newName: "IX_TeacherId");
            RenameIndex(table: "dbo.TeacherClassLetters", name: "IX_ClassLetter_Id", newName: "IX_ClassLetterId");
            RenameIndex(table: "dbo.TeachersSubjects", name: "IX_Teacher_Id", newName: "IX_TeacherId");
            RenameIndex(table: "dbo.TeachersSubjects", name: "IX_Subject_Id", newName: "IX_SubjectId");
            DropPrimaryKey("dbo.TeachersSubjects");
            AlterColumn("dbo.Teachers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Teachers", "SSN", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.TeacherAddresses", "TeacherId", c => c.Int(nullable: false));
            AlterColumn("dbo.TeacherEmailAddresses", "TeacherId", c => c.Int(nullable: false));
            AlterColumn("dbo.TeacherPhones", "TeacherId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.TeachersSubjects", new[] { "TeacherId", "SubjectId" });
            CreateIndex("dbo.TeacherAddresses", "TeacherId");
            CreateIndex("dbo.TeacherEmailAddresses", "TeacherId");
            CreateIndex("dbo.TeacherPhones", "TeacherId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.TeacherPhones", new[] { "TeacherId" });
            DropIndex("dbo.TeacherEmailAddresses", new[] { "TeacherId" });
            DropIndex("dbo.TeacherAddresses", new[] { "TeacherId" });
            DropPrimaryKey("dbo.TeachersSubjects");
            AlterColumn("dbo.TeacherPhones", "TeacherId", c => c.Int());
            AlterColumn("dbo.TeacherEmailAddresses", "TeacherId", c => c.Int());
            AlterColumn("dbo.TeacherAddresses", "TeacherId", c => c.Int());
            AlterColumn("dbo.Teachers", "SSN", c => c.String());
            AlterColumn("dbo.Teachers", "FirstName", c => c.String());
            AddPrimaryKey("dbo.TeachersSubjects", new[] { "Subject_Id", "Teacher_Id" });
            RenameIndex(table: "dbo.TeachersSubjects", name: "IX_SubjectId", newName: "IX_Subject_Id");
            RenameIndex(table: "dbo.TeachersSubjects", name: "IX_TeacherId", newName: "IX_Teacher_Id");
            RenameIndex(table: "dbo.TeacherClassLetters", name: "IX_ClassLetterId", newName: "IX_ClassLetter_Id");
            RenameIndex(table: "dbo.TeacherClassLetters", name: "IX_TeacherId", newName: "IX_Teacher_Id");
            RenameIndex(table: "dbo.TeacherAbsences", name: "IX_AbsenceId", newName: "IX_Absence_Id");
            RenameIndex(table: "dbo.TeacherAbsences", name: "IX_TeacherId", newName: "IX_Teacher_Id");
            RenameColumn(table: "dbo.TeachersSubjects", name: "TeacherId", newName: "Teacher_Id");
            RenameColumn(table: "dbo.TeachersSubjects", name: "SubjectId", newName: "Subject_Id");
            RenameColumn(table: "dbo.TeacherPhones", name: "TeacherId", newName: "Teacher_Id");
            RenameColumn(table: "dbo.TeacherEmailAddresses", name: "TeacherId", newName: "Teacher_Id");
            RenameColumn(table: "dbo.TeacherAddresses", name: "TeacherId", newName: "Teacher_Id");
            RenameColumn(table: "dbo.TeacherClassLetters", name: "ClassLetterId", newName: "ClassLetter_Id");
            RenameColumn(table: "dbo.TeacherClassLetters", name: "TeacherId", newName: "Teacher_Id");
            RenameColumn(table: "dbo.TeacherAbsences", name: "AbsenceId", newName: "Absence_Id");
            RenameColumn(table: "dbo.TeacherAbsences", name: "TeacherId", newName: "Teacher_Id");
            CreateIndex("dbo.TeacherPhones", "Teacher_Id");
            CreateIndex("dbo.TeacherEmailAddresses", "Teacher_Id");
            CreateIndex("dbo.TeacherAddresses", "Teacher_Id");
            RenameTable(name: "dbo.TeachersSubjects", newName: "SubjectTeachers");
        }
    }
}
