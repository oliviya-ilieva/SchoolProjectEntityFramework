namespace SchoolProjectEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudentsAndTeachersEntities : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.GradeStudents", newName: "StudentsGrades");
            RenameTable(name: "dbo.SubjectStudents", newName: "StudentsSubjects");
            RenameTable(name: "dbo.GradeTeachers", newName: "TeachersGrades");
            RenameColumn(table: "dbo.StudentsGrades", name: "Grade_Id", newName: "GradeId");
            RenameColumn(table: "dbo.StudentsGrades", name: "Student_Id", newName: "StudentId");
            RenameColumn(table: "dbo.StudentsSubjects", name: "Subject_Id", newName: "SubjectId");
            RenameColumn(table: "dbo.StudentsSubjects", name: "Student_Id", newName: "StudentId");
            RenameColumn(table: "dbo.TeachersGrades", name: "Grade_Id", newName: "GradeId");
            RenameColumn(table: "dbo.TeachersGrades", name: "Teacher_Id", newName: "TeacherId");
            RenameIndex(table: "dbo.TeachersGrades", name: "IX_Teacher_Id", newName: "IX_TeacherId");
            RenameIndex(table: "dbo.TeachersGrades", name: "IX_Grade_Id", newName: "IX_GradeId");
            RenameIndex(table: "dbo.StudentsGrades", name: "IX_Student_Id", newName: "IX_StudentId");
            RenameIndex(table: "dbo.StudentsGrades", name: "IX_Grade_Id", newName: "IX_GradeId");
            RenameIndex(table: "dbo.StudentsSubjects", name: "IX_Student_Id", newName: "IX_StudentId");
            RenameIndex(table: "dbo.StudentsSubjects", name: "IX_Subject_Id", newName: "IX_SubjectId");
            DropPrimaryKey("dbo.StudentsGrades");
            DropPrimaryKey("dbo.StudentsSubjects");
            DropPrimaryKey("dbo.TeachersGrades");
            AddPrimaryKey("dbo.StudentsGrades", new[] { "StudentId", "GradeId" });
            AddPrimaryKey("dbo.StudentsSubjects", new[] { "StudentId", "SubjectId" });
            AddPrimaryKey("dbo.TeachersGrades", new[] { "TeacherId", "GradeId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.TeachersGrades");
            DropPrimaryKey("dbo.StudentsSubjects");
            DropPrimaryKey("dbo.StudentsGrades");
            AddPrimaryKey("dbo.TeachersGrades", new[] { "Grade_Id", "Teacher_Id" });
            AddPrimaryKey("dbo.StudentsSubjects", new[] { "Subject_Id", "Student_Id" });
            AddPrimaryKey("dbo.StudentsGrades", new[] { "Grade_Id", "Student_Id" });
            RenameIndex(table: "dbo.StudentsSubjects", name: "IX_SubjectId", newName: "IX_Subject_Id");
            RenameIndex(table: "dbo.StudentsSubjects", name: "IX_StudentId", newName: "IX_Student_Id");
            RenameIndex(table: "dbo.StudentsGrades", name: "IX_GradeId", newName: "IX_Grade_Id");
            RenameIndex(table: "dbo.StudentsGrades", name: "IX_StudentId", newName: "IX_Student_Id");
            RenameIndex(table: "dbo.TeachersGrades", name: "IX_GradeId", newName: "IX_Grade_Id");
            RenameIndex(table: "dbo.TeachersGrades", name: "IX_TeacherId", newName: "IX_Teacher_Id");
            RenameColumn(table: "dbo.TeachersGrades", name: "TeacherId", newName: "Teacher_Id");
            RenameColumn(table: "dbo.TeachersGrades", name: "GradeId", newName: "Grade_Id");
            RenameColumn(table: "dbo.StudentsSubjects", name: "StudentId", newName: "Student_Id");
            RenameColumn(table: "dbo.StudentsSubjects", name: "SubjectId", newName: "Subject_Id");
            RenameColumn(table: "dbo.StudentsGrades", name: "StudentId", newName: "Student_Id");
            RenameColumn(table: "dbo.StudentsGrades", name: "GradeId", newName: "Grade_Id");
            RenameTable(name: "dbo.TeachersGrades", newName: "GradeTeachers");
            RenameTable(name: "dbo.StudentsSubjects", newName: "SubjectStudents");
            RenameTable(name: "dbo.StudentsGrades", newName: "GradeStudents");
        }
    }
}
