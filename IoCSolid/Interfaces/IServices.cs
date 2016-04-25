using IoCSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCSolid.Interfaces
{
    public interface IServices
    {
        List<Product> GetAllInStock();
        List<Product> GetAllLaptops();
        List<Product> GetAllMobiles();
        List<Product> GetAllMobilesInStock();
        List<Product> GetAllLaptopsInStock();
        List<Product> GetAllUndefined();
    }
}
