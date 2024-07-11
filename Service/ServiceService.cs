using Data.Repository;
using Data.Entities;

namespace Service
{
    public class ServiceService
    {
        private ServiceRepository serviceRepository;
        private static ServiceService instance;

        public ServiceService()
        {
            serviceRepository = ServiceRepository.GetInstance();
        }


        public static ServiceService GetInstance()
        {
            if (instance == null)
            {
                instance = new ServiceService();
            }
            return instance;
        }

        public IEnumerable<Data.Entities.Service> GetAllServices()
        {
            return serviceRepository.GetAllService();
        }

        public Data.Entities.Service getServiceById(int? id)
        {
            return serviceRepository.GetService((int)id);
        }
    }
}
