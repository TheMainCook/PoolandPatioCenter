namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedusers69 : DbMigration
    {
        public override void Up()
        {
            {
                Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9e61843e-cb76-4b8d-9af4-800c2fac41ad', N'admin@poolandpatio.com', 0, N'AEPARL5/ROqCzvQ2sZYVx9GZSOkG6QLs7kYCHsv8mRaz5/bOZ5ntmEkwb6qKIbRD4w==', N'187828e3-a7e7-40a8-a0d3-a45ed19370d6', NULL, 0, 0, NULL, 1, 0, N'admin@poolandpatio.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c54b93a3-7694-4068-a393-07c735ed4bdc', N'guest@poolandpatio.com', 0, N'AJ+DeQfwJoXcIuZVD89oMQU4KtTwA+WzXMDz3pQv4K7NTnf4XibH20dI0wbiDl/thg==', N'd01ea249-97e2-4be2-b5af-1f3ed2769ae4', NULL, 0, 0, NULL, 1, 0, N'guest@poolandpatio.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd0e0f0b4-2c24-4314-ae7c-a0783bf81a36', N'CanManageProducts')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9e61843e-cb76-4b8d-9af4-800c2fac41ad', N'd0e0f0b4-2c24-4314-ae7c-a0783bf81a36')
");
            }
        }
        
        public override void Down()
        {
        }
    }
}
