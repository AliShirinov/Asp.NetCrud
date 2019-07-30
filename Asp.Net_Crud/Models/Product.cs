using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetCrudApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PageCount { get; set; }
        public decimal Price { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    
    }
}