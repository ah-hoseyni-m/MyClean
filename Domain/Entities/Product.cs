﻿
namespace Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public ICollection<OrderDetail> OrderDetail { get; set; }


}
