namespace SchoolProjectEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "ClassLetter_Id", "dbo.ClassLetters");
            DropIndex("dbo.Students", new[] { "ClassLetter_Id" });
            RenameColumn(table: "dbo.Students", name: "ClassLetter_Id", newName: "ClassLetterId");
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "SSN", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Students", "ClassLetterId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "ClassLetterId");
            AddForeignKey("dbo.Students", "ClassLetterId", "dbo.ClassLetters", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ClassLetterId", "dbo.ClassLetters");
            DropIndex("dbo.Students", new[] { "ClassLetterId" });
            AlterColumn("dbo.Students", "ClassLetterId", c => c.Int());
            AlterColumn("dbo.Students", "SSN", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            RenameColumn(table: "dbo.Students", name: "ClassLetterId", newName: "ClassLetter_Id");
            CreateIndex("dbo.Students", "ClassLetter_Id");
            AddForeignKey("dbo.Students", "ClassLetter_Id", "dbo.ClassLetters", "Id");
        }
    }
}
