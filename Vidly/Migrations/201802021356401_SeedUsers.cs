namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'03cbd05b-3cce-49e4-94c2-13badf8d4de8', N'keaedwar@iu.edu', 0, N'AOzaH5haYgw13j/GRXZY9XvqWvaq7Hc9hu0K6rqsHsvp5Va5Ig8UE3Gb3k+rCDP3cQ==', N'8289ed69-7312-406b-ade8-3bdbbe6db668', NULL, 0, 0, NULL, 0, 0, N'keaedwar@iu.edu')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'38a8d62e-d997-4bde-96d8-f147fabe27ff', N'admin@vidly.com', 0, N'AD5TuaJBFvS86aYcvXEqe5pw2rZsAzXI8kKAhp76OZKsuZ1GBiIhjnDmBhvBhBsdKA==', N'8aac3740-bcb4-466b-b986-1bfb371fef23', NULL, 0, 0, NULL, 0, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'84aae5ec-6e89-464d-9cc9-e3ce151a8824', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'38a8d62e-d997-4bde-96d8-f147fabe27ff', N'84aae5ec-6e89-464d-9cc9-e3ce151a8824')
");
        }
        
        public override void Down()
        {
        }
    }
}
