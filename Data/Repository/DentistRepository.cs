using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class DentistRepository : IDentistRepository
    {
        private PrnProjectContext _context;
        private static DentistRepository instance;

        public DentistRepository(PrnProjectContext context)
        {
            _context = context;
        }

        public DentistRepository()
        {
        }

        public static DentistRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new DentistRepository();
            }
            return instance;
        }

        public IEnumerable<Dentist> GetAllDentistsByClinic(int clinicId)
        {
            using (var context = new PrnProjectContext())
            {
                return context.Dentists.Where(u => u.ClinicId == clinicId);
            }
        }

        public IEnumerable<Dentist> GetAllDentists()
        {
            using (var context  = new PrnProjectContext())
            {
                return context.Dentists.ToList();
            }
        }
    }
}
