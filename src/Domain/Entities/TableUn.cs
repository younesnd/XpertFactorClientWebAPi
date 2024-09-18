using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TableUn
{
    public string IdTableUn { get; set; } = null!;

    public int? RefAdhTbleUn { get; set; }

    public string? CompteTableUn { get; set; }

    public string? CodeTableUn { get; set; }

    public string? LibelleeTableUn { get; set; }

    public string? IntituleTableUn { get; set; }

    public decimal? DebitTableUn { get; set; }

    public decimal? CreditTableUn { get; set; }

    public DateOnly? DateTableUn { get; set; }

    public string? RefMfgAdhTableUn { get; set; }

    public string? ColonneDeuxTableUn { get; set; }

    public string? ColonneTroisTableUn { get; set; }

    public string? ColonneQuatreTableUn { get; set; }
}
