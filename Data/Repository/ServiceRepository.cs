using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ServiceRepository : IService
    {
        private PrnProjectContext prnProjectContext;

        public ServiceRepository(PrnProjectContext context)
        {
            prnProjectContext = context;
        }
        public ServiceRepository()
        {
        }
        private static ServiceRepository instance;
        public static ServiceRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new ServiceRepository();
            }
            return instance;
        }
        public IEnumerable<Service> GetAllService()
        {
            prnProjectContext = new();
            return prnProjectContext.Services.ToList();
        }
    }
}
