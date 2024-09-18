using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class SuiviActionsUtilisateur
{
    public DateTime? DateAction { get; set; }

    public string? Action { get; set; }

    public string? TableAffectée { get; set; }

    public string? RefEnregistrement { get; set; }

    public string? Utilisateur { get; set; }

    public string? IpUtilisateur { get; set; }

    public string? NomPc { get; set; }

    public string? RefContrat { get; set; }

    public string? RefIndividu { get; set; }

    public string? RôleUtilisateur { get; set; }
}
