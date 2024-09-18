using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TCommReleve
{
    public int IdCommRap { get; set; }

    public string? RefCtrCommRap { get; set; }

    public DateOnly? DatBordCommRap { get; set; }

    public string? NumBordCommRap { get; set; }

    public decimal? MontCommHtCommRap { get; set; }

    public decimal? TvaCommRap { get; set; }

    public decimal? MontCommTvaCommRap { get; set; }

    public decimal? MontCommTtcCommRap { get; set; }

    public DateTime? DateReleveCommRap { get; set; }
}
