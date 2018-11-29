namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedProductsagain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ProductsImagesId", "dbo.ProductsImages");
            DropIndex("dbo.Products", new[] { "ProductsImagesId" });
            AlterColumn("dbo.Products", "ProductsImagesId", c => c.Int());
            CreateIndex("dbo.Products", "ProductsImagesId");
            AddForeignKey("dbo.Products", "ProductsImagesId", "dbo.ProductsImages", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductsImagesId", "dbo.ProductsImages");
            DropIndex("dbo.Products", new[] { "ProductsImagesId" });
            AlterColumn("dbo.Products", "ProductsImagesId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "ProductsImagesId");
            AddForeignKey("dbo.Products", "ProductsImagesId", "dbo.ProductsImages", "Id", cascadeDelete: true);
        }
    }
}
