using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IAppointment
    {
        IEnumerable<Appointment> GetAppointmentByDate(DateOnly? date, Clinic? clinic);
        IEnumerable<Appointment> GetAppointmentByDateAndTimeSlot(DateTime selectedDate, int clinicSelect, int timeSlotSelection);
        void MakeAppointment(Appointment appointment);
        void DeleteAppointmentById(int id);
        IEnumerable<Appointment> GetAppointmentsByDentist(int dentistId);
        IEnumerable<Appointment> GetAllAppointments();

        void save(Appointment appointment);

        Appointment GetAppointmentById(int id);
    }
}
