using System;
using System.Collections.Generic;

namespace ValidationPractice.EF.Tables;

public partial class UserDatum
{
    public string User { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string Id { get; set; } = null!;
}
