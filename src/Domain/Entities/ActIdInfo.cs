using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActIdInfo
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string? UserId { get; set; }

    public string? Type { get; set; }

    public string? Key { get; set; }

    public string? Value { get; set; }

    public byte[]? Password { get; set; }

    public string? ParentId { get; set; }
}
