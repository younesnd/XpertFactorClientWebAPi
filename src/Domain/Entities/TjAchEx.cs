using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TjAchEx
{
    public int IdAchEx { get; set; }

    public int RefCtrAchEx { get; set; }

    public int RefIndAchEx { get; set; }

    public string? IdRoleCir { get; set; }
}
