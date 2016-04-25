using IoCSolid.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using IoCSolid.Repository;
using IoCSolid.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace IoCSolid.Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void GetAllInStock_Success()
        {
            var products = new List<Product>
            {
                new Product {Name = "Charger", InStock = true},
                new Product { Name = "Laptop", InStock = true},
                new Product { Name = "Phone", InStock = false},
                new Product { Name = "Phone"}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllInStock();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Charger", result[0].Name);
            Assert.AreEqual("Laptop", result[1].Name);
        }

        [TestMethod]
        public void GetAllInStock_NoProducts()
        {
            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll());
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllInStock();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllInStock_NoProductsInStock()
        {
            var products = new List<Product>
            {
                new Product {Name = "Charger", InStock = false},
                new Product { Name = "Phone", InStock = false}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllInStock();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllLaptops_Success()
        {
            var products = new List<Product>
             {
                new Product {Name = "Charger", InStock = true, Category = Enums.CategoryType.Laptop},
                new Product { Name = "Laptop", InStock = true, Category = Enums.CategoryType.Laptop},
                new Product { Name = "Phone", InStock = false},
                new Product { Name = "Mobile Phone"}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllLaptops();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Charger", result[0].Name);
            Assert.AreEqual("Laptop", result[1].Name);
        }

        [TestMethod]
        public void GetAllLaptops_NoProducts()
        {
            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll());
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllLaptops();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllLaptops_NoLaptops()
        {
            var products = new List<Product>
             {
                new Product {Name = "Charger", InStock = true, Category = Enums.CategoryType.Mobile},
                new Product { Name = "Laptop", InStock = true, Category = Enums.CategoryType.Mobile},
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllLaptops();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllMobiles_Success()
        {
            var products = new List<Product>
             {
                new Product {Name = "Charger", InStock = true, Category = Enums.CategoryType.Laptop},
                new Product { Name = "Laptop", InStock = true, Category = Enums.CategoryType.Laptop},
                new Product { Name = "Phone", InStock = false, Category = Enums.CategoryType.Mobile},
                new Product { Name = "Mobile Phone", Category = Enums.CategoryType.Mobile}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllMobiles();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Phone", result[0].Name);
            Assert.AreEqual("Mobile Phone", result[1].Name);
        }

        [TestMethod]
        public void GetAllMobiles_NoProducts()
        {
            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll());
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllMobiles();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllMobiles_NoMobiles()
        {
            var products = new List<Product>
             {
                new Product {Name = "Charger", InStock = true, Category = Enums.CategoryType.Laptop},
                new Product { Name = "Laptop", InStock = true, Category = Enums.CategoryType.Laptop}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllMobiles();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllLaptopsInStock_Success()
        {
            var products = new List<Product>
             {
                new Product {Name = "Charger", InStock = true, Category = Enums.CategoryType.Laptop},
                new Product { Name = "Laptop", InStock = true, Category = Enums.CategoryType.Laptop}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllLaptopsInStock();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Charger", result[0].Name);
            Assert.AreEqual("Laptop", result[1].Name);
        }

        [TestMethod]
        public void GetAllLaptopsInStock_NoProducts()
        {
            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll());
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllLaptopsInStock();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllLaptopsInStock_NoLaptops()
        {
            var products = new List<Product>
             {
                new Product {Name = "Charger", InStock = true, Category = Enums.CategoryType.Mobile},
                new Product { Name = "Laptop", InStock = true, Category = Enums.CategoryType.Mobile}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllLaptopsInStock();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllLaptopsInStock_NoLaptopsInStock()
        {
            var products = new List<Product>
             {
                new Product {Name = "Charger", InStock = false, Category = Enums.CategoryType.Laptop},
                new Product { Name = "Laptop", InStock = false, Category = Enums.CategoryType.Laptop}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllMobiles();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllMobilesInStock_Success()
        {
            var products = new List<Product>
             {
                new Product {Name = "Charger", InStock = true, Category = Enums.CategoryType.Mobile},
                new Product { Name = "Mobile 2", InStock = false, Category = Enums.CategoryType.Mobile},
                new Product { Name = "Mobile", InStock = true, Category = Enums.CategoryType.Mobile},
                new Product { Name = "Laptop", InStock = true, Category = Enums.CategoryType.Laptop}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllMobilesInStock();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Charger", result[0].Name);
            Assert.AreEqual("Mobile", result[1].Name);
        }

        [TestMethod]
        public void GetAllMobilesInStock_NoProducts()
        {
            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll());
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllMobilesInStock();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllMobilesInStock_NoMobiles()
        {
            var products = new List<Product>
             {
                new Product { Name = "Laptop", InStock = true, Category = Enums.CategoryType.Laptop}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllMobilesInStock();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllMobilesInStock_NoMobilesInStock()
        {
            var products = new List<Product>
             {
                new Product { Name = "Mobile 2", InStock = false, Category = Enums.CategoryType.Mobile},
                new Product { Name = "Mobile", InStock = false, Category = Enums.CategoryType.Mobile},
                new Product { Name = "Laptop", InStock = true, Category = Enums.CategoryType.Laptop}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllMobilesInStock();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetUndefined_Success()
        {
            var products = new List<Product>
             {
                new Product {Name = "Some stuff", InStock = true, Category = Enums.CategoryType.Undefined},
                new Product { Name = "Some stuff 2", InStock = false, Category = Enums.CategoryType.Undefined},
                new Product { Name = "Some stuff 3", InStock = true, Category = Enums.CategoryType.Undefined}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllUndefined();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
            Assert.AreEqual("Some stuff", result[0].Name);
            Assert.AreEqual("Some stuff 2", result[1].Name);
            Assert.AreEqual("Some stuff 3", result[2].Name);
        }

        [TestMethod]
        public void GetUndefined_NoProduct()
        {
            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll());
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllUndefined();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetUndefined_NoUndefinedProducts()
        {
            var products = new List<Product>
             {
                new Product {Name = "Laptop", InStock = true, Category = Enums.CategoryType.Laptop},
                new Product { Name = "Laptop1", InStock = false, Category = Enums.CategoryType.Laptop}
            };

            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAll()).Returns(products);
            var service = new Services(mockProductRepository.Object);

            var result = service.GetAllUndefined();

            Assert.IsNull(result);
        }
        }
}
