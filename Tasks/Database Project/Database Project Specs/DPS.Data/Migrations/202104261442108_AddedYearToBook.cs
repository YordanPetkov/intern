namespace DPS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedYearToBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Year");
        }
    }
}
