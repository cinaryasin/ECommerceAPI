using ECommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ECommerceAPI.Application.Repositories.ProductRepository;
using ECommerceAPI.Persistence.Repositories.ProductRepository;
using ECommerceAPI.Application.Repositories.CustomerRepository;
using ECommerceAPI.Persistence.Repositories.CustomerRepository;
using ECommerceAPI.Persistence.Repositories.OrderRepository;
using ECommerceAPI.Application.Repositories.OrderRepository;

namespace ECommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            
            services.AddDbContext<ECommerceAPIDbPostgreContext>(options => options.UseNpgsql(Configurations.ConnectingStringPostgre),ServiceLifetime.Singleton );
            services.AddSingleton<IProductReadRepository, ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
            services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
            services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
            services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
        }
       
    }
    //public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceAPIDbPostgreContext>
    //{
    //    public ECommerceAPIDbPostgreContext CreateDbContext(string[] args)
    //    {
           
    //        DbContextOptionsBuilder<ECommerceAPIDbPostgreContext> dbContextOptionsBuilder = new();
    //        dbContextOptionsBuilder.UseNpgsql(Configurations.ConnectingStringPostgre);
    //        return new(dbContextOptionsBuilder.Options);
    //    }
    //}
}
