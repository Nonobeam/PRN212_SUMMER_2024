using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Password { get; set; }

    public string? UserType { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Dentist? Dentist { get; set; }

    public virtual Manager? Manager { get; set; }
}
