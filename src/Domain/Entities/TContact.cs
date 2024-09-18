using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TContact
{
    public short IdContact { get; set; }

    public int RefIndContact { get; set; }

    public string? NomPreContact { get; set; }

    public string? PosContact { get; set; }

    public string? Tel1Contact { get; set; }

    public string? Tel2Contact { get; set; }

    public string? Mail1Coontact { get; set; }

    public string? Mail2Coontact { get; set; }

    public string? FaxContact { get; set; }

    public bool? ActifContact { get; set; }

    public string? GenreContact { get; set; }
}
