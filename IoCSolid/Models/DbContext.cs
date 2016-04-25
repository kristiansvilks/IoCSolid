using IoCSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IoCSolid.Models;

namespace IoCSolid.Models
{
    public class DbContext : ApplicationDbContext, IDbContext
    {
        public DbSet<Product> Products { get; set; }

        public void MarkAsModified(Product item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}