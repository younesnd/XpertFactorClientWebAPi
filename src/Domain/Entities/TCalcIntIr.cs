using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TCalcIntIr
{
    public int IdCalcIr { get; set; }

    public int? RefCtrCalcIr { get; set; }

    public string? RefDocumentDetBordIr { get; set; }

    public decimal? MontOuvDetBordIr { get; set; }

    public DateOnly? DateEcheanceIr { get; set; }

    public int? MajorIntIntFinIr { get; set; }

    public decimal? MontCalcIr { get; set; }
}
