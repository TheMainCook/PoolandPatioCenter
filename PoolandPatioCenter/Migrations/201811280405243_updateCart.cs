namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "AspNetUserId", c => c.Int(nullable: false));
            DropColumn("dbo.Carts", "AspNetUsersId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "AspNetUsersId", c => c.Int(nullable: false));
            DropColumn("dbo.Carts", "AspNetUserId");
        }
    }
}
