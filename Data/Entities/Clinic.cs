using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public partial class Clinic
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public int ManagerId { get; set; }

    public int Available { get; set; }
    public string Status
    {
        get
        {
            return Available == 0 ? "Active" : "Inactive";
        }
    }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Dentist> Dentists { get; set; } = new List<Dentist>();

    public virtual Manager? Manager { get; set; }
}
