using Domain.Entities;

namespace Domain.Repository;

public interface IOrderDetailRepository
{
    Task<int> Create(OrderDetail model);
}
