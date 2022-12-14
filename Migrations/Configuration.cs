namespace ToDoApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ToDoApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToDoApp.Models.ApplicationDbContext context)
        {
            AddUsers(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

        }

        void AddUsers(ToDoApp.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "user1@email.com" };
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            um.Create(user, "password");
        }

    }
}
