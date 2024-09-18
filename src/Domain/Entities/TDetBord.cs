using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TDetBord
{
    public string IdDetBord { get; set; } = null!;

    public int RefCtrDetBord { get; set; }

    public string AnneeBord { get; set; } = null!;

    public string NumBord { get; set; } = null!;

    public string TypDetBord { get; set; } = null!;

    public string? NumCreanceAssBord { get; set; }

    public string? TypAssDetBord { get; set; }

    public DateOnly? DatDetBord { get; set; }

    public decimal? MontTtcDetBord { get; set; }

    public string? DeviseDetBord { get; set; }

    public short? EchDetBord { get; set; }

    public DateOnly? EchAprProrogDetBord { get; set; }

    public decimal? MontOuvDetBord { get; set; }

    public short? DelaiPaieDetBord { get; set; }

    public string? ModeRegDetBord { get; set; }

    public string? TypRegDetBord { get; set; }

    public decimal? TxFdgDetBord { get; set; }

    public decimal? TxCommFactDetBord { get; set; }

    public bool? AnnulDetBord { get; set; }

    public bool? ValideDetBord { get; set; }

    public int? RefIndDetBord { get; set; }

    public decimal? MontFdgDetBord { get; set; }

    public decimal? MontFdgLibereDetBord { get; set; }

    public decimal? MontCommFactDetBord { get; set; }

    public decimal? TxTvaCommFactDetBord { get; set; }

    public decimal? MontTvaCommFactDetBord { get; set; }

    public decimal? MontTtcCommFactDetBord { get; set; }

    public int? IdCalcDispoDetBord { get; set; }

    public string? RefDetBord { get; set; }

    public string? CommDetBord { get; set; }

    public decimal? RetenuDetBord { get; set; }

    public bool? NotifWfDelaiPai { get; set; }

    public bool? NotifWfDeppLim { get; set; }

    public bool? NotifWfDateAnt { get; set; }

    public bool? NotifWfConcAch { get; set; }

    public bool? NotifWfMntMoy { get; set; }

    public bool? WfFactLitige { get; set; }

    public virtual TContrat RefCtrDetBordNavigation { get; set; } = null!;
}
