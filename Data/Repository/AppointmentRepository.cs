using Data.Entities;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

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
            return _context.Appointments ;
        }
        public IEnumerable<Appointment> GetAllAppointmentsByManger(int id)
        {
            _context = new();
            return _context.Appointments.Where(a => a.Clinic.ManagerId == id);
        }

        public IEnumerable<Appointment> GetAppointmentByDate(DateOnly? date, Clinic? clinic)
        {
            _context = new();
            return _context.Appointments.Where(a => DateOnly.FromDateTime((DateTime)a.Date)==(date) && a.Clinic.Id == clinic.Id && a.Available == 1).ToList();
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

        public void save(Appointment appointment)
        {
            _context = new();
            if(appointment.Id == null || appointment.Id == 0) {
                _context.Appointments.Add(appointment);
                _context.SaveChanges();
            }
            else
            {
                _context.Appointments.Update(appointment);
                _context.SaveChanges();
            }
        }

        public Appointment GetAppointmentById(int id)
        {
            _context = new();
            return _context.Appointments.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Appointment> GetAppointmentByDateAndTimeSlot(DateTime selectedDay, int id, int cid)
        {
            _context = new();
            return _context.Appointments.Include(a=>a.Dentist)
                .Include(S=>S.Clinic)
                .Include(e => e.Service)
                .Include(t => t.TimeSlot)
                .Include(c=>c.Customer).
                Where(a => a.Date == (selectedDay) && a.Clinic.Id == cid && a.TimeSlot.Id == id && a.Available == 1).ToList();

        }
    }
}
