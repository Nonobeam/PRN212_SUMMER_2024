using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public partial class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Phone { get; set; }

    [Required]
    public string? Password { get; set; }

    public string? UserType { get; set; }

    [Required]
    public string? Email { get; set; }

    public int Available { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Dentist? Dentist { get; set; }

    public virtual Manager? Manager { get; set; }
}
