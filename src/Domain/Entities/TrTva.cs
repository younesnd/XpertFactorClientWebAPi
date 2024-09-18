using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TrTva
{
    public short IdTva { get; set; }

    public string? LibTva { get; set; }

    public decimal? ValTva { get; set; }
}
