using System;
using System.Collections.Generic;

namespace BlazorWebApp.Models;

public partial class SubCategory
{
    public int Id { get; set; }

    public string SubCategoryId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string CatId { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
