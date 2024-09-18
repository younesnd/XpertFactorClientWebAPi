using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class RapportContrat
{
    public string? StatutContrat { get; set; }

    public string? ReferenceContrat { get; set; }

    public string? TypeContrat { get; set; }

    public DateOnly? DateSignature { get; set; }

    public DateOnly? DateDebut { get; set; }

    public DateOnly? DateResiliation { get; set; }

    public DateOnly? DateAnniversaire { get; set; }

    public decimal? ChiffreAffaires { get; set; }

    public decimal? ChiffreAffairesExport { get; set; }

    public decimal? ChiffreAffairesImport { get; set; }

    public decimal? LimiteFinancement { get; set; }

    public string? DeviseContrat { get; set; }

    public short? NombreAcheteurs { get; set; }

    public short? NombreFactures { get; set; }

    public short? NombreAvoirs { get; set; }

    public short? NombreRemises { get; set; }

    public short? DelaiMoyenReglement { get; set; }

    public short? DelaiMaxReglement { get; set; }

    public decimal? CommissionMinimum { get; set; }
}
