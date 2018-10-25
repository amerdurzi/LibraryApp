namespace LibraryApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "BorrowerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "BorrowerId", c => c.Int(nullable: false));
        }
    }
}
