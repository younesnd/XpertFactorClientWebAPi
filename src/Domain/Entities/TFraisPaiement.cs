using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TFraisPaiement
{
    public string TypFraisPaie { get; set; } = null!;

    public int RefCtrFraisPaie { get; set; }

    public decimal? MontParInstrFraisPaie { get; set; }

    public string? LibFraisPaie { get; set; }
}
