using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new() 
        {
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Product 1",
                Description = "Product 1 description",
                Price = 10,
                Quantity = 10
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Product 2",
                Description = "Product 2 description",
                Price = 20,
                Quantity = 20
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Product 3",
                Description = "Product 3 description",
                Price = 30,
                Quantity = 30
            }
        };
    }
}
