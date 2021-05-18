namespace DPS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedforeignkeytoAuthor : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AuthorRealNames", "NicknameId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AuthorRealNames", "NicknameId", c => c.Int(nullable: false));
        }
    }
}
