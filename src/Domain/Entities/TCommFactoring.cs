using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TCommFactoring
{
    public string TypCommFactoring { get; set; } = null!;

    public int RefCtrCommFactoring { get; set; }

    public decimal? TxCommFactoring { get; set; }

    public decimal? MontMinDocCommFactoring { get; set; }

    public decimal? MontMinCtrCommFactoring { get; set; }
}
