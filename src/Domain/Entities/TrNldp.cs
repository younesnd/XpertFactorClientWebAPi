using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TrNldp
{
    public int IdNldp { get; set; }

    public string? LibNt { get; set; }

    public string? AbrvNat { get; set; }

    public string? LibLang { get; set; }

    public string? AbrvLang { get; set; }

    public string? LibDevise { get; set; }

    public string? AbrvDevise { get; set; }

    public string? LibPays { get; set; }

    public string? AbrvPays { get; set; }
}
