namespace DPS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAuthorConfiguraton : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.AuthorRealNames", new[] { "Nickname_Id" });
            RenameColumn(table: "dbo.AuthorNicknames", name: "Nickname_Id", newName: "Author_Id");
            CreateIndex("dbo.AuthorNicknames", "Author_Id");
            DropColumn("dbo.AuthorRealNames", "AuthorNicknameId");
            DropColumn("dbo.AuthorRealNames", "Nickname_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AuthorRealNames", "Nickname_Id", c => c.Int());
            AddColumn("dbo.AuthorRealNames", "AuthorNicknameId", c => c.Int(nullable: false));
            DropIndex("dbo.AuthorNicknames", new[] { "Author_Id" });
            RenameColumn(table: "dbo.AuthorNicknames", name: "Author_Id", newName: "Nickname_Id");
            CreateIndex("dbo.AuthorRealNames", "Nickname_Id");
        }
    }
}
