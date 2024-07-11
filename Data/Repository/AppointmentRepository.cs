using Data.Entities;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Repository
{
    public class AppointmentRepository : IAppointment
    {
        private PrnProjectContext _context;
        private static AppointmentRepository instance;


        public AppointmentRepository()
        {
        }
        
        public static AppointmentRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new AppointmentRepository();
            }
            return instance;
        }

        public AppointmentRepository(PrnProjectContext context)
        {
            _context = context;
        }

        public IEnumerable<Appointment> GetAllAppointments() {
            _context = new();
            return _context.Appointments;
        }


        public IEnumerable<Appointment> GetAppointmentByDate(DateTime? date, Clinic? clinic)
        {
            _context = new();
            return _context.Appointments.Where(a => a.Date == date && a.Clinic == clinic && a.Available == 1).ToList();
        }

        public IEnumerable<Appointment> GetAppointmentByDateAndTimeSlot(DateTime? selectedDate, Clinic? clinicSelect, TimeSlot? timeSlotSelection)
        {
            _context = new();
            return _context.Appointments.Where(a => a.Date == selectedDate && a.Clinic == clinicSelect && a.TimeSlot == timeSlotSelection && a.Available == 1);
        }

        public void MakeAppointment(Appointment appointment)
        {
            _context = new();
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        public IEnumerable<Appointment> GetAppointmentByCustomer(User customer)
        {
            _context = new();
            return _context.Appointments.
                Include(a => a.TimeSlot)
                            .Include(a => a.Customer)
                            .ThenInclude(c => c.User)
                            .Include(a => a.Dentist)
                            .ThenInclude(d => d.User)
                            .Include(a => a.Service)
                            .Include(a => a.Clinic)
                .Where(a => a.CustomerId == customer.Id).ToList();
        }


        public void DeleteAppointmentById(int id)
        {
            _context=new();
            Appointment appointment = _context.Appointments.Where(appointment => appointment.Id == id).FirstOrDefault();
            if (appointment != null)
            {
                appointment.Available = 0;
            }
            _context.SaveChanges();
        }

        public IEnumerable<Appointment> GetAppointmentsByDentist(int dentistId)
        {
            _context = new();
            return _context.Appointments.Where(a => a.DentistId == dentistId);
        }

        public IEnumerable<Appointment> GetAppointmentsByClinicId(int clinicId)
        {
            _context = new();
            return _context.Appointments.Where(a => a.ClinicId == clinicId);
        }
    }
}
