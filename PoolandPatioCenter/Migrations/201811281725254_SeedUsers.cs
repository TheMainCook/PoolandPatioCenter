namespace PoolandPatioCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'80fdf32a-2ed0-44ac-9966-81ffc94adb9a', N'adminuser@ppc.com', 0, N'AH/O5lX2igvAVKJLgKA0U5mp9SnjbxoI51RCDYtRiJPW+kJrz6UOc5hRT6eCtvib9g==', N'd0ed4431-ad4f-476e-ad45-e115ca1a0182', NULL, 0, 0, NULL, 1, 0, N'adminuser@ppc.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f28c257c-d6a3-4d7a-a8e5-687a53dc2c29', N'testuser@ppc.com', 0, N'AJOHBS8IIBr3p8HolEJ4LUzqKwypuHYoz1mBG0vii9u3eTyNaLgo25bFpx2Bc2uUeg==', N'b5165146-e016-4a20-ad31-9e7eece22dbb', NULL, 0, 0, NULL, 1, 0, N'testuser@ppc.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3cb52435-85ab-4c6b-b9ea-0e28ad1d3287', N'PoolAdmin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'80fdf32a-2ed0-44ac-9966-81ffc94adb9a', N'3cb52435-85ab-4c6b-b9ea-0e28ad1d3287')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
