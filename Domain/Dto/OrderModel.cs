using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class OrderModel
    {
        public OrderModel()
        {
            orderDetailes = new List<OrderDetailModel>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public List<OrderDetailModel> orderDetailes { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
    }
    public record OrderVwModel
    {
        public OrderVwModel()
        {
            orderDetailes = new List<OrderDetailVwModel>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public List<OrderDetailVwModel> orderDetailes { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
    }


}

