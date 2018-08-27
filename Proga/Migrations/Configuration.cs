namespace Proga.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Proga.Data.Dbcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Proga.Data.Dbcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.BildingTypes.AddOrUpdate(_ => _.BildingName, new BildingType { BildingName = "Flat" });
            context.BildingTypes.AddOrUpdate(_ => _.BildingName, new BildingType { BildingName = "House" });
            context.SaveChanges();
            context.Bildings.AddOrUpdate(_ => _.Id, new Bilding
            {
                Floor = 5,
                Rooms = 3,
                Square = 89.56f,
                Price = 65.00M,
            });

            context.SaveChanges();

        }
    }
}
