using System;
using System.Collections.Generic;

namespace BlazorWebApp.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string SupplierId { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string ContactName { get; set; } = null!;

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
