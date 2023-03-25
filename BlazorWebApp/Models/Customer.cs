using System;
using System.Collections.Generic;

namespace BlazorWebApp.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Image { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime ModifiedDate { get; set; }
}
