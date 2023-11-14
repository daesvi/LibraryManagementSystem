namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLoan : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Loans", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Loans", "User_Identification", "dbo.Users");
            DropIndex("dbo.Loans", new[] { "Book_Id" });
            DropIndex("dbo.Loans", new[] { "User_Identification" });
            RenameColumn(table: "dbo.Loans", name: "User_Identification", newName: "UserIdentification");
            AddColumn("dbo.Loans", "BookTitle", c => c.String());
            AlterColumn("dbo.Loans", "UserIdentification", c => c.Long(nullable: false));
            CreateIndex("dbo.Loans", "UserIdentification");
            AddForeignKey("dbo.Loans", "UserIdentification", "dbo.Users", "Identification", cascadeDelete: true);
            DropColumn("dbo.Loans", "Book_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Loans", "Book_Id", c => c.Int());
            DropForeignKey("dbo.Loans", "UserIdentification", "dbo.Users");
            DropIndex("dbo.Loans", new[] { "UserIdentification" });
            AlterColumn("dbo.Loans", "UserIdentification", c => c.Long());
            DropColumn("dbo.Loans", "BookTitle");
            RenameColumn(table: "dbo.Loans", name: "UserIdentification", newName: "User_Identification");
            CreateIndex("dbo.Loans", "User_Identification");
            CreateIndex("dbo.Loans", "Book_Id");
            AddForeignKey("dbo.Loans", "User_Identification", "dbo.Users", "Identification");
            AddForeignKey("dbo.Loans", "Book_Id", "dbo.Books", "Id");
        }
    }
}
