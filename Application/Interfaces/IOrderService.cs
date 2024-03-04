using Domain.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOrderService
    {
        Task<OrderModel> Create(OrderModel model , CancellationToken cancellationToken);
        Task<IEnumerable<OrderModel>?> GetAll();
        Task<OrderVwModel?> GetById(Guid Id);

    }
}
