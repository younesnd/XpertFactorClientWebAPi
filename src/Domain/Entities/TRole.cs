using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TRole
{
    public string IdRole { get; set; } = null!;

    public string? LibRole { get; set; }

    public virtual ICollection<TjCir> TjCirs { get; set; } = new List<TjCir>();
}
