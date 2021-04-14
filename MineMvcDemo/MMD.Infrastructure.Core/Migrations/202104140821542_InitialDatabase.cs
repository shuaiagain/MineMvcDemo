namespace MMD.Infrastructure.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.usr_Account",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        AccountName = c.String(nullable: false, maxLength: 50),
                        Passwd = c.String(nullable: false, maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        LastModifyTime = c.DateTime(nullable: false),
                        LastModifyId = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "dbo.usr_User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Sex = c.Boolean(),
                        Email = c.String(),
                        Phone = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        LastModifyTime = c.DateTime(nullable: false),
                        LastModifyId = c.DateTime(nullable: false),
                        AccountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.usr_Account", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.usr_User", "UserId", "dbo.usr_Account");
            DropIndex("dbo.usr_User", new[] { "UserId" });
            DropTable("dbo.usr_User");
            DropTable("dbo.usr_Account");
        }
    }
}
