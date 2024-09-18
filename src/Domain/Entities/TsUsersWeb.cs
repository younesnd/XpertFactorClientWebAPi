using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TsUsersWeb
{
    public int IdUserWeb { get; set; }

    public int RefIndWeb { get; set; }

    public string LoginWeb { get; set; } = null!;

    public string PasswordWeb { get; set; } = null!;

    public string? LogoWeb { get; set; }

    public bool ActifUserWeb { get; set; }

    public DateOnly? DateFinCompte { get; set; }

    public string? OneSignalPlayerId { get; set; }
}
