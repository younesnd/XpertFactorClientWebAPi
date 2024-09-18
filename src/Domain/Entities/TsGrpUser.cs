using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TsGrpUser
{
    public int IdGrpUser { get; set; }

    public string? LibGrpUser { get; set; }

    public bool? ActifGrpUser { get; set; }

    public virtual ICollection<TsUser> TsUsers { get; set; } = new List<TsUser>();
}
