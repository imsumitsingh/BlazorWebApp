using System;
using System.Collections.Generic;

namespace BlazorWebApp.Models;

public partial class OrderItem
{
    public int Id { get; set; }

    public string OrderId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public decimal Quantity { get; set; }

    public decimal? Mrp { get; set; }

    public decimal? Total { get; set; }

    public decimal? Discount { get; set; }
}
