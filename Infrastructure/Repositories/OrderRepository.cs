using Domain.Entities;
using Domain.Dto;
using Domain.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly ApplicationDbContext _dbContext;

    public OrderRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Guid> Create(Order model)
    {
        
        var insertedItem = await _dbContext.Orders.AddAsync(model);

        //return model.Id;
        return insertedItem.Entity.Id;
    }

    public async Task<int> Edit(Order model)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Order>?> GetAll()
    {
        return null;

    }

    public async Task<Order?> GetById(Guid OrderId)
    {

        return await _dbContext.Orders.Include(x=>x.Customer)
            .Include(x=> x.OrderDetail)
            .ThenInclude(y=> y.Product)
            .Where(x=>x.Id== OrderId)
            .FirstOrDefaultAsync();
    }

    
}
