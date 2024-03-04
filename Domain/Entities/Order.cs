
namespace Domain.Entities;

public class Order:BaseEntity<Guid>
{
    public string Description { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public ICollection<OrderDetail> OrderDetail { get; set; }

}
