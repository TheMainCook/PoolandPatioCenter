namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateproducts3 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[Products] ( [Name], [Price], [Description], [Quantity], [ProductsImagesId], [CategoriesId]) VALUES ( N'test5', CAST(750.00 AS Decimal(18, 2)), N'A TEST 6', 0, NULL, 3)         
");
        }
        
        public override void Down()
        {
        }
    }
}
