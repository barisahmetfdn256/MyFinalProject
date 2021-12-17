using DataAccess.Abstract;
using Entities.Cocrete;
using Entities.Cocrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Cocrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1}    
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LİNQ - Language Integrated Query
        
           Product productToDelete = _products.SingleOrDefault(p=>product.ProductId==p.ProductId);
            _products.Remove(productToDelete);
            productToDelete.ProductName = product.ProductName;
            productToDelete.CategoryId = product.CategoryId;
            productToDelete.UnitPrice = product.UnitPrice;
            productToDelete.UnitsInStock = product.UnitsInStock;
        }

        public Product Get(Expression<Func<Product, bool>> fiter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllCategory(int categoryıd)
        {
            return _products.Where(p => p.CategoryId == categoryıd).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün Id'sinine sahip olan ürünü bul   
            Product productToUpdate = _products.SingleOrDefault(p => product.ProductId == p.ProductId);
            _products.Remove(productToUpdate);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
