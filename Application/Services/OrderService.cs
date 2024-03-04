using Application.Interfaces;
using Domain.Dto;
using Domain.Entities;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _IOrderRepository;
    private readonly IOrderDetailRepository _IOrderDetailRepository;
    private readonly IUnitOfWork _IUnitOfWork;

    public OrderService(IOrderRepository iOrderRepository, IOrderDetailRepository iOrderDetailRepository, IUnitOfWork iUnitOfWork)
    {
        _IOrderRepository = iOrderRepository;
        _IOrderDetailRepository = iOrderDetailRepository;
        _IUnitOfWork = iUnitOfWork;
    }

    public async Task<OrderModel> Create(OrderModel model, CancellationToken cancellationToken)
    {
        var entity = new Order()
        {
            Id = Guid.NewGuid() ,
        CustomerId = model.CustomerId,
            Description = model.Description,
            CreateAt = DateTime.Now,
        };
        
        var Hdr =  await _IOrderRepository.Create(entity);
        model.Id = entity.Id;

        foreach (var item in model.orderDetailes)
        {
            var entityDtl = new OrderDetail()
            {
                ProductId = item.ProductId,
                OrderId = model.Id,
                CreateAt = DateTime.Now,
                PricePerOne = item.PricePerOne,
                ProductCount = item.ProductCount,
            };

            await _IOrderDetailRepository.Create(entityDtl);
            item.Id = entityDtl.Id;
        }
        await _IUnitOfWork.SaveChangeAsync();
        return model;
    }

    public async Task<IEnumerable<OrderModel>?> GetAll()
    {

        throw new NotImplementedException();
    }

    public async Task<OrderVwModel?> GetById(Guid Id)
    {
        var order = await _IOrderRepository.GetById(Id);

        return new OrderVwModel
        {
            CreateAt = DateTime.Now,
            CustomerName = order.Customer.Name,
            Description = order.Description,
            Id = order.Id,
            orderDetailes = order.OrderDetail.Select(x => new OrderDetailVwModel
            {
                OrderId = Id,
                Id = x.Id,
                PricePerOne= x.PricePerOne,
                ProductCount = x.ProductCount,
                ProductName = x.Product.Name,
            }).ToList()
        };

        //throw new NotImplementedException();

        //return await _IOrderRepository.GetById(Id);
        

    }
}
