using System.Web.Mvc;

namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedusers68 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'83d1873b-26a2-4978-a56b-a7ec4f25838e', N'guest@poolandpatio.com', 0, N'ACzXZhViNyxoYd95HrdoiH/M5JKiCQkWl+MZTFEamFpTB4WRIzg5IJL8otoD7jZQ/Q==', N'3d97a112-cd6b-472c-96e5-4b88638db7b8', NULL, 0, 0, NULL, 1, 0, N'guest@poolandpatio.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd0e0f0b4-2c24-4314-ae7c-a0783bf81a36', N'CanManageProducts')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9e61843e-cb76-4b8d-9af4-800c2fac41ad', N'd0e0f0b4-2c24-4314-ae7c-a0783bf81a36')

");
        }
        
        public override void Down()
        {
        }
    }
}
