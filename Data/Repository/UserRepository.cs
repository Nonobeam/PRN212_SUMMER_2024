using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : IUser
    {
        private PrnProjectContext prnProjectContext;

        public UserRepository(PrnProjectContext context)
        {
            prnProjectContext = context;
        }
        public UserRepository()
        {
        }
        private static UserRepository instance;
        public static UserRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new UserRepository();
            }
            return instance;
        }
        public IEnumerable<Dentist> GetDentistsByClinic(int? clinicId)
        {
            prnProjectContext = new();
            return prnProjectContext.Dentists.Where(d => d.ClinicId == clinicId);
        }
    }
}
