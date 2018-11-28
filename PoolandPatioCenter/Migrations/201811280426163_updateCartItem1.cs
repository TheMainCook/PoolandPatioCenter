namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCartItem1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.CartItems", "CartId");
            CreateIndex("dbo.CartItems", "ProductId");
            AddForeignKey("dbo.CartItems", "CartId", "dbo.Carts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CartItems", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.CartItems", "CartId", "dbo.Carts");
            DropIndex("dbo.CartItems", new[] { "ProductId" });
            DropIndex("dbo.CartItems", new[] { "CartId" });
        }
    }
}
