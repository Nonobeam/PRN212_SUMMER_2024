using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Manager
{
    public int UserId { get; set; }

    public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();

    public virtual User User { get; set; } = null!;
}
