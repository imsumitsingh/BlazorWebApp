﻿using System;
using System.Collections.Generic;

namespace BlazorWebApp.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public string? OrderNumber { get; set; }

    public int CustomerId { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? TotalQty { get; set; }
}
