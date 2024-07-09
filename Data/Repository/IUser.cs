using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    internal interface IUser
    {
        IEnumerable<Dentist> GetDentistsByClinic(int? clinicId);
        User GetUserById(int id);
        IEnumerable<User> GetAllUsersByType(string type);
        void AddUser(User user);
        bool PhoneExists(string phone);
        bool EmailExists(string email);
        int ChangeUserAvailable(int id, int available);
        IEnumerable<User> GetAllUsers();
        public User GetUserByEmail(String email);

    }
}
