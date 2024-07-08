using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ClinicRepository : IClinic
    {
        private PrnProjectContext _context;
        private static ClinicRepository instance;

        public ClinicRepository(){}
        
        public static ClinicRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new ClinicRepository();
            }
            return instance;
        }


        public ClinicRepository(PrnProjectContext context)
        {
            _context = context;
        }


        public IEnumerable<Clinic> GetAllClinics()
        {
            _context = new();
            return _context.Clinics
                       .Include(c => c.Manager)
                       .ThenInclude(m => m.User).Where(c => c.Available == 1).ToList();
        }
        public void AddClinic(Clinic clinic)
        {
            _context = new();
            _context.Add(clinic);
        }

        public int ChangeClinicAvailable(int id, int available)
        {
            using (var context = new PrnProjectContext())
            {
                var clinic = context.Clinics.FirstOrDefault(u => u.Id == id);
                if (clinic != null)
                {
                    clinic.Available = available;
                    context.Clinics.Update(clinic);
                    return context.SaveChanges();
                }
            }
            return 0;
        }
    }
}
