using Business.Cocrete;
using DataAccess.Cocrete.EntityFramework;
using DataAccess.Cocrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productmanager = new ProductManager(new EfProductDal());
            foreach (var product in productmanager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName  + " Fiyat: " + product.UnitPrice);
            }
            
        }
    }
}
