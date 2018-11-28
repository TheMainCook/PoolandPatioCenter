namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductsImagesId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "ProductsImageId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductsImageId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "ProductsImagesId");
        }
    }
}
