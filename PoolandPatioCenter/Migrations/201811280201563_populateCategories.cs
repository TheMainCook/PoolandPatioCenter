namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (CategoryName) VALUES ('Pool Chemicals')");
            Sql("INSERT INTO Categories (CategoryName) VALUES ('Grills')");
            Sql("INSERT INTO Categories (CategoryName) VALUES ('Spas')");
            Sql("INSERT INTO Categories (CategoryName) VALUES ('Entertainment')");
            Sql("INSERT INTO Categories (CategoryName) VALUES ('Patio')");
            Sql("INSERT INTO Categories (CategoryName) VALUES ('Furniture')");
        }
        
        public override void Down()
        {
        }
    }
}
