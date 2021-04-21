namespace Station.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Place1 = c.String(),
                        Place2 = c.String(),
                        TrainId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trains", t => t.TrainId, cascadeDelete: true)
                .Index(t => t.TrainId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserTrips",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Trip_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Trip_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Trips", t => t.Trip_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Trip_Id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTrips", "Trip_Id", "dbo.Trips");
            DropForeignKey("dbo.UserTrips", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Trips", "TrainId", "dbo.Trains");
            DropIndex("dbo.UserTrips", new[] { "Trip_Id" });
            DropIndex("dbo.UserTrips", new[] { "User_Id" });
            DropIndex("dbo.Trips", new[] { "TrainId" });
            DropTable("dbo.UserTrips");
            DropTable("dbo.Users");
            DropTable("dbo.Trips");
            DropTable("dbo.Trains");
        }
    }
}
