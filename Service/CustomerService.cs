using Data.Entities;
using Data.Repository;


namespace Service
{
    public class CustomerService
    {
        private CustomerRepository customerRepository;
        private UserRepository userRepository;
        private static CustomerService instance;

        public CustomerService()
        {
            customerRepository = CustomerRepository.GetInstance();
            userRepository = UserRepository.GetInstance();
        }


        public static CustomerService GetInstance()
        {
            if (instance == null)
            {
                instance = new CustomerService();
            }
            return instance;
        }

        public IEnumerable<User> GetAllCustomers()
        {
            string customer = "Customer";
            return userRepository.GetAllUsersByType(customer);
        }

    }
}
