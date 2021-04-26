namespace DPS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBookAuthorToAuthorNickname : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Authors", newName: "AuthorRealNames");
            RenameTable(name: "dbo.Nicknames", newName: "AuthorNicknames");
            RenameColumn(table: "dbo.Books", name: "AuthorId", newName: "AuthorNicknameId");
            RenameIndex(table: "dbo.Books", name: "IX_AuthorId", newName: "IX_AuthorNicknameId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Books", name: "IX_AuthorNicknameId", newName: "IX_AuthorId");
            RenameColumn(table: "dbo.Books", name: "AuthorNicknameId", newName: "AuthorId");
            RenameTable(name: "dbo.AuthorNicknames", newName: "Nicknames");
            RenameTable(name: "dbo.AuthorRealNames", newName: "Authors");
        }
    }
}
