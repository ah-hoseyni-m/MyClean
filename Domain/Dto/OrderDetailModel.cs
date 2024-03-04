
using System.ComponentModel.DataAnnotations;

namespace Domain.Dto;

public record OrderDetailModel
{
    public int Id { get; set; }
    public Guid OrderId { get; set; }
    public int ProductId { get; set; }
    public int ProductCount { get; set; }
    public double PricePerOne { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;
    public int TaxPercent { get; set; }
}

public record OrderDetailVwModel
{
    public int Id { get; set; }
    public Guid OrderId { get; set; }
    public string ProductName { get; set; }
    public int ProductCount { get; set; }
    public double PricePerOne { get; set; }
    public int TaxPercent { get; set; }
}
