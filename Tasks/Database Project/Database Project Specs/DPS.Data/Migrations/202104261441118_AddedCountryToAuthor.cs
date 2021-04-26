namespace DPS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCountryToAuthor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Country");
        }
    }
}
