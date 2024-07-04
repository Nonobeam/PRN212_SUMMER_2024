using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data.Repository
{
    public class AppointmentRepository : IAppointment
    {
        private PrnProjectContext prnProjectContext;
        public AppointmentRepository()
        {
        }
        private static AppointmentRepository instance;
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
            prnProjectContext = context;
        }
        public IEnumerable<Appointment> GetAppointmentByDate(DateTime? date, Clinic? clinic)
        {
            prnProjectContext = new();
            return prnProjectContext.Appointments.Where(a => a.Date == date && a.Clinic == clinic).ToList();
        }

        public IEnumerable<Appointment> GetAppointmentByDateAndTimeSlot(DateTime? selectedDate, Clinic? clinicSelect, TimeSlot? timeSlotSelection)
        {
            prnProjectContext = new();
            return prnProjectContext.Appointments.Where(a => a.Date == selectedDate && a.Clinic == clinicSelect && a.TimeSlot == timeSlotSelection);
        }

        public void MakeAppointment(Appointment appointment)
        {
            prnProjectContext = new();
            prnProjectContext.Appointments.Add(appointment);
            prnProjectContext.SaveChanges();
        }

        public IEnumerable<Appointment> GetAppointmentByCustomer(Customer customer)
        {
prnProjectContext = new();
            return prnProjectContext.Appointments.Where(a => a.CustomerId == customer.UserId).ToList();
                }

        public void DeleteAppointmentById(int id)
        {
            prnProjectContext=new();
            Appointment appointment = prnProjectContext.Appointments.Where(appointment => appointment.Id == id).FirstOrDefault();
            if (appointment != null)
            {
                appointment.Available = 0;
            }
            prnProjectContext.SaveChanges();
        }
    }
}
