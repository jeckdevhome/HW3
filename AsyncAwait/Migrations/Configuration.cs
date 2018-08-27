namespace AsyncAwait.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AsyncAwait.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<AsyncAwait.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AsyncAwait.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Students.AddOrUpdate(_ => _.Id, new Student
            {
                Name = "Jon",
                LastName = "Bill",
                Ball = 45,
                Group = "Kochegar"
            });
        }
    }
}
