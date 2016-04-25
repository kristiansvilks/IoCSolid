using IoCSolid.Interfaces;
using IoCSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IoCSolid.Repository
{
    public class ProductRepository : IProductRepository
    {
        private IDbContext db;

        public ProductRepository(IDbContext dbContext)
        {
            this.db = dbContext;
        }

        List<Product> IProductRepository.GetAll()
        {
            return db.Products.ToList();
        }

        public Product Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();

            Product products = db.Products.Find(id);
            Product result = null;

            if(products != null)
            {
                result = products;
            }

            return result;
        }

        public Product Add(Product item)
        {
            if (item == null)
                throw new ArgumentNullException();

            db.Products.Add(item);
            db.SaveChanges();

            return item;
        }

        public Product Update(Product item)
        {
            db.MarkAsModified(item);
            db.SaveChanges();

            return item;
        }

        public Product Delete(int id)
        {
            Product products = db.Products.Find(id);
            db.Products.Remove(products);
            db.SaveChanges();

            return products;
        }
    }
}