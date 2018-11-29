namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedLastBoughtagain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Reviewstring", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Reviewstring");
        }
    }
}
