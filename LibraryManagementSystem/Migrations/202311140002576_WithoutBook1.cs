namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WithoutBook1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Loans", "Book1_Id", "dbo.Books");
            DropIndex("dbo.Loans", new[] { "Book1_Id" });
            DropColumn("dbo.Loans", "Book1_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Loans", "Book1_Id", c => c.Int());
            CreateIndex("dbo.Loans", "Book1_Id");
            AddForeignKey("dbo.Loans", "Book1_Id", "dbo.Books", "Id");
        }
    }
}
