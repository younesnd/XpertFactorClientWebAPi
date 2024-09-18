using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TrListeFraisDiver
{
    public string AbrevFraisDivers { get; set; } = null!;

    public string LibFraisDivers { get; set; } = null!;

    public decimal? MontFraisDivers { get; set; }

    public string? TypeFraisDivers { get; set; }

    public int IdListeFraisDivers { get; set; }
}
