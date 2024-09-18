using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActIdTenant
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ActIdTenantMember> ActIdTenantMembers { get; set; } = new List<ActIdTenantMember>();
}
