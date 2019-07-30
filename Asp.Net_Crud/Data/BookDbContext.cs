using ASPNetCrudApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNetCrudApp.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext() : base("MyBook") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
    
    
}