namespace SchoolProjectEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Absences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Absences = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        SSN = c.String(),
                        ClassLetter_Id = c.Int(),
                        ClassNumber_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassLetters", t => t.ClassLetter_Id)
                .ForeignKey("dbo.ClassNums", t => t.ClassNumber_Id)
                .Index(t => t.ClassLetter_Id)
                .Index(t => t.ClassNumber_Id);
            
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.ClassLetters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Letter = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        SSN = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeacherAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.ClassNums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeacherEmailAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Grades = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeacherPhones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentEmailAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.StudentPhones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.StudentAbsences",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Absence_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Absence_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Absences", t => t.Absence_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Absence_Id);
            
            CreateTable(
                "dbo.TeacherAbsences",
                c => new
                    {
                        Teacher_Id = c.Int(nullable: false),
                        Absence_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_Id, t.Absence_Id })
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id, cascadeDelete: true)
                .ForeignKey("dbo.Absences", t => t.Absence_Id, cascadeDelete: true)
                .Index(t => t.Teacher_Id)
                .Index(t => t.Absence_Id);
            
            CreateTable(
                "dbo.ClassNumTeachers",
                c => new
                    {
                        ClassNum_Id = c.Int(nullable: false),
                        Teacher_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClassNum_Id, t.Teacher_Id })
                .ForeignKey("dbo.ClassNums", t => t.ClassNum_Id, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id, cascadeDelete: true)
                .Index(t => t.ClassNum_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.TeacherClassLetters",
                c => new
                    {
                        Teacher_Id = c.Int(nullable: false),
                        ClassLetter_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_Id, t.ClassLetter_Id })
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id, cascadeDelete: true)
                .ForeignKey("dbo.ClassLetters", t => t.ClassLetter_Id, cascadeDelete: true)
                .Index(t => t.Teacher_Id)
                .Index(t => t.ClassLetter_Id);
            
            CreateTable(
                "dbo.GradeStudents",
                c => new
                    {
                        Grade_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Grade_Id, t.Student_Id })
                .ForeignKey("dbo.Grades", t => t.Grade_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Grade_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.GradeTeachers",
                c => new
                    {
                        Grade_Id = c.Int(nullable: false),
                        Teacher_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Grade_Id, t.Teacher_Id })
                .ForeignKey("dbo.Grades", t => t.Grade_Id, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id, cascadeDelete: true)
                .Index(t => t.Grade_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.SubjectStudents",
                c => new
                    {
                        Subject_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_Id, t.Student_Id })
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Subject_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.SubjectTeachers",
                c => new
                    {
                        Subject_Id = c.Int(nullable: false),
                        Teacher_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_Id, t.Teacher_Id })
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id, cascadeDelete: true)
                .Index(t => t.Subject_Id)
                .Index(t => t.Teacher_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentPhones", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentEmailAddresses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Students", "ClassNumber_Id", "dbo.ClassNums");
            DropForeignKey("dbo.Students", "ClassLetter_Id", "dbo.ClassLetters");
            DropForeignKey("dbo.SubjectTeachers", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.SubjectTeachers", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.SubjectStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.SubjectStudents", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.TeacherPhones", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.GradeTeachers", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.GradeTeachers", "Grade_Id", "dbo.Grades");
            DropForeignKey("dbo.GradeStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.GradeStudents", "Grade_Id", "dbo.Grades");
            DropForeignKey("dbo.TeacherEmailAddresses", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.TeacherClassLetters", "ClassLetter_Id", "dbo.ClassLetters");
            DropForeignKey("dbo.TeacherClassLetters", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.ClassNumTeachers", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.ClassNumTeachers", "ClassNum_Id", "dbo.ClassNums");
            DropForeignKey("dbo.TeacherAddresses", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.TeacherAbsences", "Absence_Id", "dbo.Absences");
            DropForeignKey("dbo.TeacherAbsences", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.StudentAddresses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentAbsences", "Absence_Id", "dbo.Absences");
            DropForeignKey("dbo.StudentAbsences", "Student_Id", "dbo.Students");
            DropIndex("dbo.SubjectTeachers", new[] { "Teacher_Id" });
            DropIndex("dbo.SubjectTeachers", new[] { "Subject_Id" });
            DropIndex("dbo.SubjectStudents", new[] { "Student_Id" });
            DropIndex("dbo.SubjectStudents", new[] { "Subject_Id" });
            DropIndex("dbo.GradeTeachers", new[] { "Teacher_Id" });
            DropIndex("dbo.GradeTeachers", new[] { "Grade_Id" });
            DropIndex("dbo.GradeStudents", new[] { "Student_Id" });
            DropIndex("dbo.GradeStudents", new[] { "Grade_Id" });
            DropIndex("dbo.TeacherClassLetters", new[] { "ClassLetter_Id" });
            DropIndex("dbo.TeacherClassLetters", new[] { "Teacher_Id" });
            DropIndex("dbo.ClassNumTeachers", new[] { "Teacher_Id" });
            DropIndex("dbo.ClassNumTeachers", new[] { "ClassNum_Id" });
            DropIndex("dbo.TeacherAbsences", new[] { "Absence_Id" });
            DropIndex("dbo.TeacherAbsences", new[] { "Teacher_Id" });
            DropIndex("dbo.StudentAbsences", new[] { "Absence_Id" });
            DropIndex("dbo.StudentAbsences", new[] { "Student_Id" });
            DropIndex("dbo.StudentPhones", new[] { "Student_Id" });
            DropIndex("dbo.StudentEmailAddresses", new[] { "Student_Id" });
            DropIndex("dbo.TeacherPhones", new[] { "Teacher_Id" });
            DropIndex("dbo.TeacherEmailAddresses", new[] { "Teacher_Id" });
            DropIndex("dbo.TeacherAddresses", new[] { "Teacher_Id" });
            DropIndex("dbo.StudentAddresses", new[] { "Student_Id" });
            DropIndex("dbo.Students", new[] { "ClassNumber_Id" });
            DropIndex("dbo.Students", new[] { "ClassLetter_Id" });
            DropTable("dbo.SubjectTeachers");
            DropTable("dbo.SubjectStudents");
            DropTable("dbo.GradeTeachers");
            DropTable("dbo.GradeStudents");
            DropTable("dbo.TeacherClassLetters");
            DropTable("dbo.ClassNumTeachers");
            DropTable("dbo.TeacherAbsences");
            DropTable("dbo.StudentAbsences");
            DropTable("dbo.StudentPhones");
            DropTable("dbo.StudentEmailAddresses");
            DropTable("dbo.Subjects");
            DropTable("dbo.TeacherPhones");
            DropTable("dbo.Grades");
            DropTable("dbo.TeacherEmailAddresses");
            DropTable("dbo.ClassNums");
            DropTable("dbo.TeacherAddresses");
            DropTable("dbo.Teachers");
            DropTable("dbo.ClassLetters");
            DropTable("dbo.StudentAddresses");
            DropTable("dbo.Students");
            DropTable("dbo.Absences");
        }
    }
}
