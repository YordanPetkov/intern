namespace DPS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAutoIncrementIds : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "AuthorNicknameId", "dbo.AuthorNicknames");
            DropIndex("dbo.AuthorNicknames", new[] { "Id" });
            DropPrimaryKey("dbo.AuthorNicknames");
            AlterColumn("dbo.AuthorNicknames", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.AuthorNicknames", "Id");
            CreateIndex("dbo.AuthorNicknames", "Id");
            AddForeignKey("dbo.Books", "AuthorNicknameId", "dbo.AuthorNicknames", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorNicknameId", "dbo.AuthorNicknames");
            DropIndex("dbo.AuthorNicknames", new[] { "Id" });
            DropPrimaryKey("dbo.AuthorNicknames");
            AlterColumn("dbo.AuthorNicknames", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.AuthorNicknames", "Id");
            CreateIndex("dbo.AuthorNicknames", "Id");
            AddForeignKey("dbo.Books", "AuthorNicknameId", "dbo.AuthorNicknames", "Id", cascadeDelete: true);
        }
    }
}