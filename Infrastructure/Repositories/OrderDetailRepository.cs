using Domain.Entities;
using Domain.Repository;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories;

public class OrderDetailRepository : IOrderDetailRepository
{
    private readonly ApplicationDbContext _dbContext;

    public OrderDetailRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> Create(OrderDetail model)
    {
        await _dbContext.AddAsync(model);
        return model.Id;
    }

    public async Task SaveChangeAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
