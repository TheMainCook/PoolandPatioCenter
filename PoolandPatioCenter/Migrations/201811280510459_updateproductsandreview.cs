namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateproductsandreview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LastBoughts", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Reviews", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Products", "CategoriesId");
            CreateIndex("dbo.Products", "ProductsImagesId");
            CreateIndex("dbo.LastBoughts", "ProductsId");
            CreateIndex("dbo.LastBoughts", "UserId");
            CreateIndex("dbo.Reviews", "ProductsId");
            CreateIndex("dbo.Reviews", "UserId");
            AddForeignKey("dbo.Products", "CategoriesId", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "ProductsImagesId", "dbo.ProductsImages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LastBoughts", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.LastBoughts", "ProductsId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Reviews", "ProductsId", "dbo.Products", "Id", cascadeDelete: true);
            DropColumn("dbo.LastBoughts", "AspNetUsersId");
            DropColumn("dbo.Reviews", "AspNetUsersId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "AspNetUsersId", c => c.Int(nullable: false));
            AddColumn("dbo.LastBoughts", "AspNetUsersId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Reviews", "ProductsId", "dbo.Products");
            DropForeignKey("dbo.Reviews", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.LastBoughts", "ProductsId", "dbo.Products");
            DropForeignKey("dbo.LastBoughts", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Products", "ProductsImagesId", "dbo.ProductsImages");
            DropForeignKey("dbo.Products", "CategoriesId", "dbo.Categories");
            DropIndex("dbo.Reviews", new[] { "UserId" });
            DropIndex("dbo.Reviews", new[] { "ProductsId" });
            DropIndex("dbo.LastBoughts", new[] { "UserId" });
            DropIndex("dbo.LastBoughts", new[] { "ProductsId" });
            DropIndex("dbo.Products", new[] { "ProductsImagesId" });
            DropIndex("dbo.Products", new[] { "CategoriesId" });
            DropColumn("dbo.Reviews", "UserId");
            DropColumn("dbo.LastBoughts", "UserId");
        }
    }
}
