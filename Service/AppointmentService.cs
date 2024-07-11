using Data.Entities;
using Data.Repository;
using System.Collections.ObjectModel;

namespace Service
{
    public class AppointmentService
    {
        private AppointmentRepository appointmentRepository;
        private static AppointmentService instance;

        public AppointmentService()
        {
            appointmentRepository = AppointmentRepository.GetInstance();
        }


        public static AppointmentService GetInstance()
        {
            if (instance == null)
            {
                instance = new();
            }
            return instance;
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return appointmentRepository.GetAllAppointments();
        }

        public IEnumerable<Appointment> GetAppointmentsByDentist(int dentistId)
        {
            return appointmentRepository.GetAppointmentsByDentist(dentistId);
        }

        public IEnumerable<Appointment> GetAppointmentsByClinicId(int clinicId)
        {
            return appointmentRepository.GetAppointmentsByClinicId(clinicId);
        }

        public void AddAppoinment(Appointment appointment)
        {
            appointmentRepository.save(appointment);
        }

        public Appointment GetAppointment(int id)
        {
            return appointmentRepository.GetAppointmentById(id);
        }
    }
}
