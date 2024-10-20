using System;
using System.Collections.Generic;

namespace DBFirstNorthwindMVC.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
