using Data.Entities;
using Data.Repository;

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
    }
}
