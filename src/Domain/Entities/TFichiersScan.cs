using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TFichiersScan
{
    public int IdScan { get; set; }

    public string? NomFichierScan { get; set; }

    public DateOnly? DateScan { get; set; }

    public string? AdresseScan { get; set; }

    public string? AffectScan { get; set; }

    public string? NomFichierSansExt { get; set; }
}
