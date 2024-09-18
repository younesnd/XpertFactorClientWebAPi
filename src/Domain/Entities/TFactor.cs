using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TFactor
{
    public int IdFactor { get; set; }

    public string? RaisonSocial { get; set; }

    public string? Abrv { get; set; }

    public string? Rc { get; set; }

    public string? Mf { get; set; }

    public string? CodeTva { get; set; }

    public string? CodeDouane { get; set; }

    public string? Adresse { get; set; }

    public string? Capital { get; set; }

    public string? CapitalLettre { get; set; }

    public byte[]? Logo16 { get; set; }

    public byte[]? Logo32 { get; set; }

    public byte[]? Logo48 { get; set; }

    public string? Email { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? SiteWeb { get; set; }

    public string? Exercice { get; set; }

    public string? Devise { get; set; }

    public string? Langue { get; set; }

    public string? Pays { get; set; }

    public string? SrvDb { get; set; }

    public string? Db { get; set; }

    public string? CnxDb { get; set; }

    public string? MdpCnx { get; set; }

    public bool? DetDocGed { get; set; }

    public string? NomRep { get; set; }

    public string? Fonction { get; set; }
}
