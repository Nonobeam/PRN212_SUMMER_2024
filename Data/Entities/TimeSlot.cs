using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class TimeSlot
{
    public int Id { get; set; }

    public TimeOnly? Time { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
