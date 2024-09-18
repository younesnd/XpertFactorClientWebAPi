using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TEmail
{
    public int IdEmail { get; set; }

    public int IdUser { get; set; }

    public string TitreGroupe { get; set; } = null!;
}
