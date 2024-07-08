using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : IUser
    {
        private PrnProjectContext _context;
        private static UserRepository instance;

        public UserRepository(PrnProjectContext context)
        {
            _context = context;
        }

        public UserRepository()
        {
        }
        
        public static UserRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new UserRepository();
            }
            return instance;
        }

        public User GetUserByEmail(String email)
        {
            using (var _context = new PrnProjectContext())
            {
                User user = _context.Users.FirstOrDefault(u => u.Email == email);
                return user;
            }
        }

        public IEnumerable<Dentist> GetDentistsByClinic(int? clinicId)
        {
            _context = new();
            return _context.Dentists.Where(d => d.ClinicId == clinicId);
        }

        public IEnumerable<Dentist> GetDentistsByClinic(string clinicId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            _context = new();
            return _context.Users.ToList();
        }

        public int ChangeUserAvailable(int id, int available)
        {
            using (var context = new PrnProjectContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == id);
                if (user != null)
                {
                    user.Available = available;
                    context.Users.Update(user);
                    return context.SaveChanges();
                }
            }
            return 0;
        }

        public bool EmailExists(string email)
        {
            using (var context = new PrnProjectContext())
            {
                return context.Users.Any(u => u.Email == email);
            }
        }

        public bool PhoneExists(string phone)
        {
            using (var context = new PrnProjectContext())
            {
                return context.Users.Any(u => u.Phone == phone);
            }
        }

        public void AddUser(User user)
        {
            using (var context = new PrnProjectContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public User GetUserById(int id)
        {
            using (var context = new PrnProjectContext())
            {
                return context.Users.FirstOrDefault(u => u.Id.Equals(id));
            }
        }

        public IEnumerable<User> GetAllUsersByType(string type)
        {
            var context = new PrnProjectContext();
            return context.Users.Where(u => u.UserType == type);
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            using (var contex = new PrnProjectContext())
            {
                return contex.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            }
        }

        public List<User> GetDentistNameInOneClinic(int clinicId)
        {
            using (var context = new PrnProjectContext())
            {
                var dentistUsers = context.Clinics
                    .Where(c => c.Id == clinicId)
                    .SelectMany(c => c.Dentists)
                    .Select(d => d.User)
                    .ToList();

                return dentistUsers;
            }  
        }
    }
}
