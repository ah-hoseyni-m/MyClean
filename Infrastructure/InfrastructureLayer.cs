using Application.Interfaces;
using Application.Services;
using Domain.Repository;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection;

public static class InfrastructureLayer
{
    public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services , string connectionString)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IOrderRepository, OrderRepository>();
        services.AddTransient<IOrderDetailRepository, OrderDetailRepository>();
      return   services.AddTransient<IUnitOfWork, UnitOfWork>();

    }
}
