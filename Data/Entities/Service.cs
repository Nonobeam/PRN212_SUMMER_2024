using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Service
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
