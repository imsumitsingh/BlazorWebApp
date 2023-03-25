using System;
using System.Collections.Generic;

namespace BlazorWebApp.Models;

public partial class Category
{
    public int Id { get; set; }

    public string CategoryId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Discription { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
