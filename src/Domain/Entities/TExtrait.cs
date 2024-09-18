using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TExtrait
{
    public long IdExtrait { get; set; }

    public int? RefCtrExtrait { get; set; }

    public string? LibExtrait { get; set; }

    public DateTime? DatOpExtrait { get; set; }

    public DateTime? DatValExtrait { get; set; }

    public decimal? DebitExtrait { get; set; }

    public decimal? CreditExtrait { get; set; }

    public decimal? EncourfactExtrait { get; set; }

    public decimal? TotalFinExtrait { get; set; }

    public decimal? DisponibleExtrait { get; set; }

    public decimal? FdgExtrait { get; set; }

    public decimal? AutreExtrait { get; set; }
}
