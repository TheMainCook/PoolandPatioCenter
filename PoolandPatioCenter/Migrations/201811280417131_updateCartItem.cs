namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCartItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartItems", "CartId", c => c.Int(nullable: false));
            AddColumn("dbo.CartItems", "ProductId", c => c.Int(nullable: false));
            DropColumn("dbo.CartItems", "CartsId");
            DropColumn("dbo.CartItems", "ProductsId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CartItems", "ProductsId", c => c.Int(nullable: false));
            AddColumn("dbo.CartItems", "CartsId", c => c.Int(nullable: false));
            DropColumn("dbo.CartItems", "ProductId");
            DropColumn("dbo.CartItems", "CartId");
        }
    }
}
