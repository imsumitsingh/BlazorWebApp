using System;
using System.Collections.Generic;

namespace BlazorWebApp.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductId { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string SupplierId { get; set; } = null!;

    public decimal SalePrice { get; set; }

    public decimal Mrp { get; set; }

    public decimal Tax { get; set; }

    public decimal? Discount { get; set; }

    public bool IsDiscontinued { get; set; }

    public string Image { get; set; } = null!;

    public string? Thumbnail { get; set; }

    public string CategoryId { get; set; } = null!;

    public string SubCatId { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
