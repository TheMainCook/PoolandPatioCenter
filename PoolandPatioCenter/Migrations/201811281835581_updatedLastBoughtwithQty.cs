namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedLastBoughtwithQty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LastBoughts", "LastBoughtQuantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LastBoughts", "LastBoughtQuantity");
        }
    }
}
