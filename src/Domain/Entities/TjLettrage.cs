using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TjLettrage
{
    public int IdDetBordLet { get; set; }

    public int IdEncLet { get; set; }

    public DateOnly DatLet { get; set; }

    public decimal MontTtcLet { get; set; }

    public DateOnly? DatReconcil { get; set; }

    public bool? ValideLet { get; set; }

    public bool ValideReconcil { get; set; }

    public int IdLet { get; set; }
}
