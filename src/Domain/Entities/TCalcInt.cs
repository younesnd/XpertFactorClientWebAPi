using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TCalcInt
{
    public int IdCalcInt { get; set; }

    public int RefCtrCalcInt { get; set; }

    public decimal? MontCalcInt { get; set; }

    public DateOnly? DatCalcInt { get; set; }

    public virtual TContrat RefCtrCalcIntNavigation { get; set; } = null!;
}
