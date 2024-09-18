using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TrListVal
{
    public string AbrListVal { get; set; } = null!;

    public string TypListVal { get; set; } = null!;

    public short? OrdListVal { get; set; }

    public string? LibListVal { get; set; }

    public string? ComListVal { get; set; }

    public int IdListVal { get; set; }

    public int? NbJourListVal { get; set; }

    public string? TypeRecouvrement { get; set; }

    public virtual ICollection<TjGrpPermission> TjGrpPermissions { get; set; } = new List<TjGrpPermission>();
}
