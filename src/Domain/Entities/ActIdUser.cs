﻿using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActIdUser
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string? First { get; set; }

    public string? Last { get; set; }

    public string? Email { get; set; }

    public string? Pwd { get; set; }

    public string? Salt { get; set; }

    public DateTime? LockExpTime { get; set; }

    public int? Attempts { get; set; }

    public string? PictureId { get; set; }

    public virtual ICollection<ActIdTenantMember> ActIdTenantMembers { get; set; } = new List<ActIdTenantMember>();

    public virtual ICollection<ActIdGroup> Groups { get; set; } = new List<ActIdGroup>();
}
