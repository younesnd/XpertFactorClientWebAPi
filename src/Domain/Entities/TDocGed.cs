using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TDocGed
{
    public int Id { get; set; }

    public int? IdIndGed { get; set; }

    public int? IdCtrGed { get; set; }

    public int? IdBorGed { get; set; }

    public int? IdDetBordGed { get; set; }

    public int? IdEncGed { get; set; }

    public int? IdDebitGed { get; set; }

    public int? IdCreditGed { get; set; }

    public int? IdFincanementGed { get; set; }

    public int? AnneeBordGed { get; set; }

    public string LibelleGed { get; set; } = null!;

    public DateTime DateTacheGed { get; set; }

    public int? IdGestionnaireGed { get; set; }

    public DateTime? DateScanGed { get; set; }

    public string? AdressDocGed { get; set; }

    public byte[]? DataGed { get; set; }

    public string? NameGed { get; set; }

    public string? SalleGed { get; set; }

    public string? ArmoireGed { get; set; }

    public string? EtgageGed { get; set; }

    public string? ArchiveGed { get; set; }

    public string? Libelle2Ged { get; set; }

    public string? IdEmetteurGed { get; set; }

    public string? EtapeGed { get; set; }

    public bool? EtatGed { get; set; }
}
