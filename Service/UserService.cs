using Data.Entities;
using Data.Repository;

namespace Service
{
    public class UserService
    {
        private UserRepository userRepository;
        private static UserService instance;

        public UserService()
        {
            userRepository = UserRepository.GetInstance();
        }


        public static UserService GetInstance()
        {
            if (instance == null)
            {
                instance = new UserService();
            }
            return instance;
        }


        public User Login(String email, String password)
        {
            User user = userRepository.GetUserByEmailAndPassword(email, password);
            return user;
        }


        public IEnumerable<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }

        
        public int ChangeUserAvailable(int id, int available)
        {
            return userRepository.ChangeUserAvailable(id, available);
        }

        public bool EmailExists(string email)
        {
            return userRepository.EmailExists(email);
        }

        public bool PhoneExists(string phone)
        {
            return userRepository.PhoneExists(phone);
        }

        public void AddUser(User user)
        {
            userRepository.AddUser(user);
        }

        public User GetUserById(int? id)
        {
            return userRepository.GetUserById((int)id);
        }

        public List<User> GetDentistNameInOneClinic(int clinicId)
        {
            return userRepository.GetDentistNameInOneClinic(clinicId);
        }

        public User? getUserByEmail(string email)
        {
            return userRepository.GetUserByEmail(email);    
        }

        public void deleteUserById(int id)
        {
            userRepository.deleteUserById(id);
        }
    }
}
