namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedReviewandLastBought : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LastBoughts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastBoughtDate = c.DateTime(nullable: false),
                        ProductsId = c.Int(nullable: false),
                        AspNetUsersId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReviewDate = c.DateTime(nullable: false),
                        ProductsId = c.Int(nullable: false),
                        AspNetUsersId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reviews");
            DropTable("dbo.LastBoughts");
        }
    }
}
