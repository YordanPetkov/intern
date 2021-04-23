namespace DPS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNickname : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nicknames",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.Authors", "NicknameId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Nicknames", "Id", "dbo.Authors");
            DropIndex("dbo.Nicknames", new[] { "Id" });
            DropColumn("dbo.Authors", "NicknameId");
            DropTable("dbo.Nicknames");
        }
    }
}
