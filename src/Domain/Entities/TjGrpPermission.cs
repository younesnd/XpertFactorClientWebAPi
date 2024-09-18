using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TjGrpPermission
{
    public int IdGrp { get; set; }

    public int IdPermission { get; set; }

    public virtual TrListVal IdPermissionNavigation { get; set; } = null!;
}
