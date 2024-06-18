using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Customer
{
    public int UserId { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual User User { get; set; } = null!;
}
