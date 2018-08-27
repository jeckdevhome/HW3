namespace BookStoreMvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookStoreMvc.Data;
    using BookStoreMvc.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStoreMvc.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookStoreMvc.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Books.AddOrUpdate(_ => _.Name, new Book {
               Name = "Red",
               Author =" Serg Luk",
               Price = 150,
               Reiting = 4.9f               
            });
            context.Books.AddOrUpdate(_ => _.Name, new Book
            {
                Name = "Bilbo",
                Author = " Tolkien",
                Price = 200,
                Reiting = 5.0f
            });
            context.SaveChanges();
        }
    }
}
