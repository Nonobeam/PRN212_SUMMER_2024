using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Dentist
{
    public int UserId { get; set; }

    public int ClinicId { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual Clinic Clinic { get; set; }

    public virtual User User { get; set; } = null!;
}
