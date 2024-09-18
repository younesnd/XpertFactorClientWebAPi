using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TRespAg
{
    public int IdRespAg { get; set; }

    public int IdUserAg { get; set; }

    public string IdRoleResp { get; set; } = null!;

    public bool? StateResp { get; set; }

    public string RespCodeAg { get; set; } = null!;
}
