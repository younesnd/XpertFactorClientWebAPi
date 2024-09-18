using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class SegmentationPrédictionContrat
{
    public int ReferenceContrat { get; set; }

    public string? StatutContrat { get; set; }

    public string? TypeContrat { get; set; }

    public DateOnly? DateDebutContrat { get; set; }

    public DateOnly? DateResiliationContrat { get; set; }

    public decimal? ChiffreAffaires { get; set; }

    public decimal? LimiteFinancement { get; set; }

    public string? DeviseContrat { get; set; }

    public string? NomIndividu { get; set; }

    public string? PrenomIndividu { get; set; }

    public string? VilleIndividu { get; set; }

    public DateOnly? DateEncaissement { get; set; }

    public decimal? MontantEncaissement { get; set; }

    public string? NumeroBordereau { get; set; }

    public DateOnly? DateBordereau { get; set; }

    public decimal? MontantTtcBordereau { get; set; }

    public decimal? RetenueBordereau { get; set; }
}
