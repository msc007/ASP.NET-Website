namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'80d821ff-3b5f-4398-9374-64a68b71960e', N'guest@vidly.com', 0, N'AIhK1qSGfvCpdoT2kKTJ/tKtnYTgsaFCrcUieoYM3g7BuKOYH9jKvPitWVOiXMU32Q==', N'cc87e74d-1eb6-4483-9dee-4e43a4d50be3', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
              INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f75495e2-2186-4572-b33f-f1016c1e6bc8', N'admin@vidly.com', 0, N'ACvKzIUT9aYw9TG+kETeQNAGEuJZPZAGTRmGvpEwabLeV6Hnoko7zhoMliOXM9KDTA==', N'd7765458-00a8-4a95-a5e8-c1ef7047408b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
              INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7b83c41c-eb1a-4475-8840-425b371a978c', N'CanManageMovies')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
