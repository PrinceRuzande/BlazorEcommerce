using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.DataStore
{
    public class ProductRepository: IProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>
            {
                new Product { Id = 1, Brand = "Brand", Name = "Prince", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 2, Brand = "Brand", Name = "Prince", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 3, Brand = "Brand", Name = "Prince", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 4, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 5, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 6, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 7, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 8, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 9, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 10, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 11, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 12, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 13, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 14, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 15, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 16, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 17, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 18, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 19, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 20, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 21, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 22, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 23, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"},
                new Product { Id = 24, Brand = "Brand", Name = "Name", Price = 14.1, ImageLink ="", Description = "Some Description"}
            };
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProducts(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) 
                return products;
            return products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
        }
    }
}
