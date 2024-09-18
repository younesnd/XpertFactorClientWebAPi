using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class THistorique
{
    public int IdHistorique { get; set; }

    public DateTime? DateAction { get; set; }

    public string? Action { get; set; }

    public string? TTable { get; set; }

    public string? IdEnregistrement { get; set; }

    public string? LoginUser { get; set; }

    public string? IpPc { get; set; }

    public string? NomPc { get; set; }

    public string? RefCtrHist { get; set; }

    public string? RefIndHist { get; set; }

    public string? AbrevRoleHist { get; set; }

    public int IdHistoriquee { get; set; }
}
