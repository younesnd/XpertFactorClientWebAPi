using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TjCir
{
    public int IdCir { get; set; }

    public int RefCtrCir { get; set; }

    public int RefIndCir { get; set; }

    public string IdRoleCir { get; set; } = null!;

    public bool? IsNotifiedAch { get; set; }

    public bool? IsDocReceived { get; set; }

    public bool? NotifAch { get; set; }

    public bool? IsNotifiedAnalyst { get; set; }

    public bool? IsNotifiedAss { get; set; }

    public string? ScoreAch { get; set; }

    public virtual TRole IdRoleCirNavigation { get; set; } = null!;

    public virtual TContrat RefCtrCirNavigation { get; set; } = null!;

    public virtual TIndividu RefIndCirNavigation { get; set; } = null!;
}
