using System;
using System.Collections.Generic;

namespace AvaloniaApplication3.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime ClosingDate { get; set; }
}
