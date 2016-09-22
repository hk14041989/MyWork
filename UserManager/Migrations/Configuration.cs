namespace UserManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UserManager.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UserManager.Models.UserDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UserManager.Models.UserDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Users.AddOrUpdate(i => i.FirstName,
             new User
             {
                 FirstName = "Kiên",
                 LastName = "Phạm Hoàng",
                 BirthDay = DateTime.Parse("1989-4-14"),
                 Job = "DEV",
                 Address = "Hòa Bình"
             },
             new User
             {
                 FirstName = "Tùng",
                 LastName = "Nguyễn Thanh",
                 BirthDay = DateTime.Parse("1990-11-17"),
                 Job = "TEST",
                 Address = "Thái Nguyên"
             },
             new User
             {
                 FirstName = "Mai",
                 LastName = "Trần Phương",
                 BirthDay = DateTime.Parse("1993-05-30"),
                 Job = "ADMIN",
                 Address = "Ninh Bình"
             },
             new User
             {
                 FirstName = "Yến",
                 LastName = "Lê Hoài ",
                 BirthDay = DateTime.Parse("1995-06-13"),
                 Job = "DESIGN",
                 Address = "Hà Tĩnh"
             });
        }
    }
}
