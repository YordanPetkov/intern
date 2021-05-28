namespace DPS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAuthorConfiguratio : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AuthorNicknames", "Id", "dbo.AuthorRealNames");
            DropForeignKey("dbo.Books", "AuthorNicknameId", "dbo.AuthorNicknames");
            DropIndex("dbo.AuthorNicknames", new[] { "Id" });
            DropPrimaryKey("dbo.AuthorNicknames");
            AddColumn("dbo.AuthorRealNames", "Nickname_Id", c => c.Int());
            AlterColumn("dbo.AuthorNicknames", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.AuthorNicknames", "Id");
            CreateIndex("dbo.AuthorRealNames", "Nickname_Id");
            AddForeignKey("dbo.AuthorRealNames", "Nickname_Id", "dbo.AuthorNicknames", "Id");
            AddForeignKey("dbo.Books", "AuthorNicknameId", "dbo.AuthorNicknames", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorNicknameId", "dbo.AuthorNicknames");
            DropForeignKey("dbo.AuthorRealNames", "Nickname_Id", "dbo.AuthorNicknames");
            DropIndex("dbo.AuthorRealNames", new[] { "Nickname_Id" });
            DropPrimaryKey("dbo.AuthorNicknames");
            AlterColumn("dbo.AuthorNicknames", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.AuthorRealNames", "Nickname_Id");
            AddPrimaryKey("dbo.AuthorNicknames", "Id");
            CreateIndex("dbo.AuthorNicknames", "Id");
            AddForeignKey("dbo.Books", "AuthorNicknameId", "dbo.AuthorNicknames", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AuthorNicknames", "Id", "dbo.AuthorRealNames", "Id");
        }
    }
}
