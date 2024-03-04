using Domain.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IOrderRepository
    {
        Task<Guid> Create(Order model);
        Task<int> Edit(Order model);
        Task<IEnumerable<Order>?> GetAll();
        Task<Order?> GetById(Guid OrderId);

    }
}
