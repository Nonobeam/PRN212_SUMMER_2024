using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ClinicRepository : IClinic
    {
        private PrnProjectContext prnProjectContext;
        public ClinicRepository()
        {
        }
        private static ClinicRepository instance;
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
            prnProjectContext = context;
        }

        public IEnumerable<Clinic> GetAll()
        {
            prnProjectContext = new();
            return prnProjectContext.Clinics.ToList();
        }
    }
}
