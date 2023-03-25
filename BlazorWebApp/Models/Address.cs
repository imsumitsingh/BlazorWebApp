using System;
using System.Collections.Generic;

namespace BlazorWebApp.Models;

public partial class Address
{
    public int Id { get; set; }

    public string CustomerId { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public int Pin { get; set; }

    public string? Area { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
