using System;
using System.Collections.Generic;

namespace AvaloniaApplication3.Models;

public partial class Service
{
    public int Id { get; set; }

    public string Nomination { get; set; } = null!;

    public string Price { get; set; } = null!;
}
