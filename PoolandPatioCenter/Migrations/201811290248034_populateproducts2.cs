namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateproducts2 : DbMigration
    {
        public override void Up()
        {

            Sql(@"
            INSERT INTO [dbo].[Products] ( [Name], [Price], [Description], [Quantity], [ProductsImagesId], [CategoriesId]) VALUES ( N'testo2', CAST(150.00 AS Decimal(18, 2)), N'A TEST 3', 1, NULL, 3)
            INSERT INTO [dbo].[Products] ( [Name], [Price], [Description], [Quantity], [ProductsImagesId], [CategoriesId]) VALUES ( N'teSTO3', CAST(75.00 AS Decimal(18, 2)), N'A TEST 4', 5, NULL, 4)
            INSERT INTO [dbo].[Products] ( [Name], [Price], [Description], [Quantity], [ProductsImagesId], [CategoriesId]) VALUES ( N'teSTO4', CAST(5.00 AS Decimal(18, 2)), N'A TEST 5', 100, NULL, 5)          
");

        }

        public override void Down()
        {
        }
    }
}
