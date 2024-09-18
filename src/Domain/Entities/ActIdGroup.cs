using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActIdGroup
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<ActIdTenantMember> ActIdTenantMembers { get; set; } = new List<ActIdTenantMember>();

    public virtual ICollection<ActIdUser> Users { get; set; } = new List<ActIdUser>();
}
