namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCart1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Carts", "UserId");
            AddForeignKey("dbo.Carts", "UserId", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Carts", "AspNetUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "AspNetUserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Carts", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Carts", new[] { "UserId" });
            DropColumn("dbo.Carts", "UserId");
        }
    }
}
