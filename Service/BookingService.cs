using Data.Entities;
using Data.Repository;
namespace Service
{
    public class BookingService
    {
        private TimeslotRepository timeslotRepository;
        private ServiceRepository serviceRepository;
        private AppointmentRepository appointmentRepository;
        private ClinicRepository clinicRepository;
        private UserRepository userRepository;
        private static BookingService instance;

        public BookingService()
        {
            timeslotRepository = TimeslotRepository.GetInstance();
            appointmentRepository = AppointmentRepository.GetInstance();
            serviceRepository = ServiceRepository.GetInstance();
            clinicRepository = ClinicRepository.GetInstance();
            userRepository = UserRepository.GetInstance();
        }


        public static BookingService GetInstance()
        {
            if (instance == null)
            {
                instance = new BookingService();
            }
            return instance;
        }

        public IEnumerable<TimeSlot?> GetTimeSlotForBooking(DateTime? selectedDate, Clinic clinic)
        {
            IEnumerable<TimeSlot> timeSlotsForBook = timeslotRepository.GetSlots();
            IEnumerable<Appointment> getBooked = appointmentRepository.GetAppointmentByDate(selectedDate, clinic);
            var bookedTimeSlots = getBooked.Where(book => book != null)
                               .Select(book => book.TimeSlot);

            var availableTimeSlots = timeSlotsForBook.Except(bookedTimeSlots);
            return availableTimeSlots;
        }

        public IEnumerable<Clinic> GetAllClinic()
        {
            IEnumerable<Clinic> clinics = clinicRepository.GetAllClinics();
            return clinics;
        }

        public IEnumerable<Dentist> GetDentistListForBooking(TimeSlot? timeSlotSelection, Clinic? clinicSelect, DateTime? selectedDate)
        {
            IEnumerable<Appointment> getBooked = appointmentRepository.GetAppointmentByDateAndTimeSlot(selectedDate, clinicSelect,timeSlotSelection);
            IEnumerable<Dentist> dentists = userRepository.GetDentistsByClinic(clinicSelect.Id);
            var bookedDentist = getBooked.Select(book => book.Dentist);
            var availableDentist = dentists.Except(bookedDentist);
            return availableDentist;
        }

        public IEnumerable<Data.Entities.Service> GetServiceForBooking()
        {
            return serviceRepository.GetAllService();
        }

        public void MakeAppointment(Appointment appointment)
        {
             appointmentRepository.MakeAppointment(appointment);
        }

        public IEnumerable<Appointment> GetAppointmentHistory(User customer)
        {
            return appointmentRepository.GetAppointmentByCustomer(customer);
        }

        public IEnumerable<Appointment> GetAppointmentHistorySearch(User customer, String search, DateTime? searchDate)
        {
            IEnumerable<Appointment> list = appointmentRepository.GetAppointmentByCustomer(customer);
            return list.Where(a => a.Customer.User.Name.Equals(search) || a.Service.Name.Equals(search) || a.Date.Equals(searchDate)).ToList();
        }

        public void DeleteAppointment(int id)
        {
            appointmentRepository.DeleteAppointmentById(id);
        }
    }
}
