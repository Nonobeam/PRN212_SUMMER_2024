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
        IEnumerable<Appointment> GetAppointmentByDate(DateTime? date, Clinic? clinic);
        IEnumerable<Appointment> GetAppointmentByDateAndTimeSlot(DateTime? selectedDate, Clinic? clinicSelect, TimeSlot? timeSlotSelection);
        void MakeAppointment(Appointment appointment);
        void DeleteAppointmentById(int id);
        IEnumerable<Appointment> GetAppointmentsByDentist(int dentistId);
        IEnumerable<Appointment> GetAllAppointments();
    }
}
