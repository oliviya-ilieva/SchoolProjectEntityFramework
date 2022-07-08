namespace SchoolProjectEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeClassNumForeignKeyName : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "ClassNumber_Id", "dbo.ClassNums");
            DropIndex("dbo.Students", new[] { "ClassNumber_Id" });
            RenameColumn(table: "dbo.Students", name: "ClassNumber_Id", newName: "ClassNumberId");
            AlterColumn("dbo.Students", "ClassNumberId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "ClassNumberId");
            AddForeignKey("dbo.Students", "ClassNumberId", "dbo.ClassNums", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ClassNumberId", "dbo.ClassNums");
            DropIndex("dbo.Students", new[] { "ClassNumberId" });
            AlterColumn("dbo.Students", "ClassNumberId", c => c.Int());
            RenameColumn(table: "dbo.Students", name: "ClassNumberId", newName: "ClassNumber_Id");
            CreateIndex("dbo.Students", "ClassNumber_Id");
            AddForeignKey("dbo.Students", "ClassNumber_Id", "dbo.ClassNums", "Id");
        }
    }
}
