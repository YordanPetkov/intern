namespace DPS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNicknameIdtoAuthorNicknameId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AuthorRealNames", name: "NicknameId", newName: "AuthorNicknameId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.AuthorRealNames", name: "AuthorNicknameId", newName: "NicknameId");
        }
    }
}
