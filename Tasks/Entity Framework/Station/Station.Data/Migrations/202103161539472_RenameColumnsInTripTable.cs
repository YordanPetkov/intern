namespace Station.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameColumnsInTripTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Trips", name: "Place1", newName: "Starting Point");
            RenameColumn(table: "dbo.Trips", name: "Place2", newName: "Destination");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Trips", name: "Destination", newName: "Place2");
            RenameColumn(table: "dbo.Trips", name: "Starting Point", newName: "Place1");
        }
    }
}
