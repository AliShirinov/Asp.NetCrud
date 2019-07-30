using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetCrudApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}