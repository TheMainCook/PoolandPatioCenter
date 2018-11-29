namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateproducts : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[Products] ( [Name], [Price], [Description], [Quantity], [ProductsImagesId], [CategoriesId]) VALUES ( N'teSTO', CAST(50.00 AS Decimal(18, 2)), N'A TEST 2', 10, NULL, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
