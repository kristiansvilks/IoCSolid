using IoCSolid.Enums;
using IoCSolid.Interfaces;
using IoCSolid.Models;
using IoCSolid.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoCSolid
{
    public class Services : IServices
    {
        private IProductRepository productRepo;

        public Services(IProductRepository productRepo)
        {
            this.productRepo = productRepo;
        }

        public List<Product> GetAllInStock()
        {
            List<Product> result = null;

            var products = productRepo.GetAll();

            if (products != null)
            {
                var inStock = products.Where(x => x.InStock == true).ToList();

                if (inStock != null 
                    && inStock.Count > 0)
                {
                    result = inStock;
                }
            }

            return result;
        }

        public List<Product> GetAllLaptops()
        {
            List<Product> result = null;

            var products = productRepo.GetAll();

            if (products != null)
            {
                var laptops = products.Where(x => x.Category == CategoryType.Laptop).ToList();

                if (laptops != null
                    && laptops.Count > 0)
                {
                    result = laptops;
                }
            }

            return result;
        }

        public List<Product> GetAllMobiles()
        {
            List<Product> result = null;

            var products = productRepo.GetAll();

            if (products != null
                && products.Count > 0)
            {
                var mobiles = products.Where(x => x.Category == CategoryType.Mobile).ToList();

                if (mobiles != null
                    && mobiles.Count > 0)
                {
                    result = mobiles;
                }
            }

            return result;
        }

        public List<Product> GetAllMobilesInStock()
        {
            List<Product> result = null;

            var products = productRepo.GetAll();

            if (products != null)
            {
                var mobiles = products.Where(x => x.Category == CategoryType.Mobile).ToList();

                if (mobiles != null
                    && mobiles.Count > 0)
                {
                    var mobilesInStock = mobiles.Where(x => x.InStock == true).ToList();

                    if (mobilesInStock != null
                        && mobilesInStock.Count > 0)
                    {
                        result = mobilesInStock;
                    }

                }

            }

            return result;
        }

        public List<Product> GetAllLaptopsInStock()
        {
            List<Product> result = null;

            var products = productRepo.GetAll();

            if (products != null)
            {
                var laptops = products.Where(x => x.Category == CategoryType.Laptop).ToList();

                if (laptops != null
                    && laptops.Count > 0)
                {
                    var laptopsInStock = laptops.Where(x => x.InStock == true).ToList();

                    if (laptopsInStock != null
                        && laptopsInStock.Count > 0)
                    {
                        result = laptopsInStock;
                    }

                }

            }

            return result;
        }

        public List<Product> GetAllUndefined()
        {
            List<Product> result = null;

            var products = productRepo.GetAll();

            if (products != null)
            {
                var undefined = products.Where(x => x.Category == CategoryType.Undefined).ToList();

                if (undefined != null
                    && undefined.Count > 0)
                {
                    result = undefined;
                }

            }

            return result;
        }

    }
}