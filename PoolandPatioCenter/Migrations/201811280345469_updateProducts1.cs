namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProducts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CategoriesId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "CategoriesId");
        }
    }
}
