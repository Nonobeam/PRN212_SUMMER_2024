using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Admin
{
    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
