using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IDentistRepository
    {
        IEnumerable<Dentist> GetAllDentists();
        IEnumerable<Dentist> GetAllDentistsByClinic(int clinicId);
    }
}
