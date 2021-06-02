namespace DPS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNicknameIdpropertytoAuthorRealNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AuthorRealNames", "NicknameId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AuthorRealNames", "NicknameId");
        }
    }
}
