using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CustomerRepository
    {
        private PrnProjectContext _context;
        private static CustomerRepository instance;

        public CustomerRepository(PrnProjectContext context)
        {
            _context = context;
        }

        public CustomerRepository()
        {
        }

        public static CustomerRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new CustomerRepository();
            }
            return instance;
        }
    }
}
