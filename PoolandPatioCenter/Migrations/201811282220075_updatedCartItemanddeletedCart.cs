namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedCartItemanddeletedCart : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carts", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.CartItems", "CartId", "dbo.Carts");
            DropIndex("dbo.Carts", new[] { "UserId" });
            DropIndex("dbo.CartItems", new[] { "CartId" });
            AddColumn("dbo.CartItems", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.CartItems", "UserId");
            AddForeignKey("dbo.CartItems", "UserId", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.CartItems", "CartId");
            DropTable("dbo.Carts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.CartItems", "CartId", c => c.Int(nullable: false));
            DropForeignKey("dbo.CartItems", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.CartItems", new[] { "UserId" });
            DropColumn("dbo.CartItems", "UserId");
            CreateIndex("dbo.CartItems", "CartId");
            CreateIndex("dbo.Carts", "UserId");
            AddForeignKey("dbo.CartItems", "CartId", "dbo.Carts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Carts", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
