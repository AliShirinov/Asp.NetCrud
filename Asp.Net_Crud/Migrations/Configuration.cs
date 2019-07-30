namespace ASPNetCrudApp.Migrations
{
    using ASPNetCrudApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPNetCrudApp.Data.BookDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ASPNetCrudApp.Data.BookDbContext context)
        {
            if (!context.Genres.Any())
            {
                Genre genre = new Genre()
                {
                    Name = "Romantic"
                };
                context.Genres.Add(genre);
                context.SaveChanges();
            }
        }
    }
}
