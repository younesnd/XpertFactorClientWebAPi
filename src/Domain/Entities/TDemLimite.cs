using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TDemLimite
{
    public int RefDemLim { get; set; }

    public int RefCtrDemLim { get; set; }

    public string TypDemLim { get; set; } = null!;

    public DateOnly DatDemLim { get; set; }

    public string? SortDemLim { get; set; }

    public decimal? MontDemLim { get; set; }

    public string? Devise { get; set; }

    public DateOnly? DatLastDemLim { get; set; }

    public string? DecisionLim { get; set; }

    public decimal? MontAcc { get; set; }

    public decimal? MontLimAchAdh { get; set; }

    public DateOnly? DatAnnulDemLim { get; set; }

    public DateOnly? DatlimDemLim { get; set; }

    public short? DelaisDemLim { get; set; }

    public short? DelaisAcc { get; set; }

    public string? ModePayDemLim { get; set; }

    public string? ModePayAcc { get; set; }

    public bool? ActifDemLimi { get; set; }

    public int? RefAchLim { get; set; }

    public bool? NotifWfGest { get; set; }

    public bool? NotifWfAdh { get; set; }

    public bool? NotifWfAssu { get; set; }

    public string? Comment { get; set; }

    public bool? NotifWfRevision { get; set; }

    public string? StatusLim { get; set; }
}
