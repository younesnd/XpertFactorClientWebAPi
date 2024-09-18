using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class PerformanceContrat
{
    public int ReferenceContrat { get; set; }

    public string? StatutContrat { get; set; }

    public DateOnly? DateDebutContrat { get; set; }

    public DateOnly? DateResiliationContrat { get; set; }

    public decimal? ChiffreAffaires { get; set; }

    public string? DeviseContrat { get; set; }

    public decimal? LimiteFinancement { get; set; }

    public short? NombreAcheteursPrevu { get; set; }

    public short? NombreFacturesPrevu { get; set; }

    public string? NomAcheteur { get; set; }

    public string? PrenomAcheteur { get; set; }

    public string? VilleAcheteur { get; set; }

    public string? PaysAcheteur { get; set; }

    public string? NumeroBordereau { get; set; }

    public string? TypeBordereau { get; set; }

    public DateOnly? DateBordereau { get; set; }

    public decimal? MontantTtcBordereau { get; set; }

    public DateOnly? DateEncaissement { get; set; }

    public decimal? MontantEncaissement { get; set; }
}
