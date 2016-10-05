using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using TestDAO;
using NUnit.Framework;
namespace UnitTest
{
    [TestFixture]
    class TestProductDAO
    {
        [Test]
        public void TestAddProduct()
        {
            ProductEntity objEntity = new ProductEntity();
            objEntity.Pid = 1001;
            objEntity.Pname = "Xyz";
            objEntity.Price = 100;
            objEntity.Stock = 10;
            ProductDAO objProduct = new ProductDAO();
            int res = objProduct.AddProduct(objEntity);
            Assert.AreEqual(1, res);

        }
        [Test]
        public void TestGetProductById()
        {
            ProductDAO objProduct = new ProductDAO();
            ProductEntity objEntity = objProduct.GetProduct(100);
            Assert.IsNotNull(objEntity);
        }
    }
}
