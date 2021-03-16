namespace Station.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameUserTableToPassenger : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "Passenger");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Passenger", newName: "Users");
        }
    }
}
