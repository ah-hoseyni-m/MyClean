
namespace Domain.Entities;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public ICollection<Order> Order { get; set; }


}
