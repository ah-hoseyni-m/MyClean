
namespace Domain.Entities;

public class OrderDetail:BaseEntity
{
    public Guid OrderId { get; set; }
    public int ProductId { get; set; }
    public int ProductCount { get; set; }
    public double PricePerOne { get; set;}
    public int TaxPercent { get; set; }
    public Product Product { get; set; }
    public  Order Order { get; set; }


}
