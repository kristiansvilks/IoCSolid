using IoCSolid.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCSolid.Interfaces
{
    public interface IDbContext
    {
        DbSet<Product> Products { get; set; }
        int SaveChanges();
        void MarkAsModified(Product item);
    }
}
