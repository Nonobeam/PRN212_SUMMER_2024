using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Appointment
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public int? TimeSlotId { get; set; }

    public int? CustomerId { get; set; }

    public int? DentistId { get; set; }

    public int? ServiceId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Dentist? Dentist { get; set; }

    public virtual Service? Service { get; set; }

    public virtual TimeSlot? TimeSlot { get; set; }
}
