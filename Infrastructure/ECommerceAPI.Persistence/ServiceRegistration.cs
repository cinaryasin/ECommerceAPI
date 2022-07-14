using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Persistence.Concretes;
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

namespace ECommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            
            services.AddDbContext<ECommerceAPIDbPostgreContext>(options =>
            {
                options.UseNpgsql(Configurations.ConnectingStringPostgre);
            });
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
