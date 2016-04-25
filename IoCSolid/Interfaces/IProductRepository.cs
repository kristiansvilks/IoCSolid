using IoCSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoCSolid.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product Get(int? id);
        Product Add(Product item);
        Product Update(Product item);
        Product Delete(int id);
    }
}