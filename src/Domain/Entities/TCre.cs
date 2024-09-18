using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TCre
{
    public int IdRefCre { get; set; }

    public string? NomFichierCre { get; set; }

    public DateTime? DateGenCre { get; set; }
}
