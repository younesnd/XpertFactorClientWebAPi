using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TBctRcm00
{
    public int IdRcm00 { get; set; }

    public string CodeRcm00 { get; set; } = null!;

    public decimal? C1Rcm00 { get; set; }

    public decimal? C2Rcm00 { get; set; }

    public decimal? C3Rcm00 { get; set; }

    public decimal? C4Rcm00 { get; set; }

    public decimal? C5Rcm00 { get; set; }

    public decimal? C6Rcm00 { get; set; }

    public decimal? C7Rcm00 { get; set; }

    public decimal? C8Rcm00 { get; set; }

    public DateOnly DateRcm00 { get; set; }

    public bool? ValideRcm00 { get; set; }
}
