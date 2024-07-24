using Data.Entities;
using Data.Repository;
using System;
using System.Diagnostics;
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
            DateOnly? selectedDay = selectedDate.HasValue ? DateOnly.FromDateTime(selectedDate.Value) : (DateOnly?)null;
            IEnumerable<Appointment> getBooked = appointmentRepository.GetAppointmentByDate(selectedDay, clinic);
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
            IEnumerable<Appointment> getBooked = appointmentRepository.GetAppointmentByDateAndTimeSlot((DateTime)selectedDate, timeSlotSelection.Id, clinicSelect.Id);
            Console.WriteLine(getBooked);
            IEnumerable<Dentist> dentists = userRepository.GetDentistsByClinic(clinicSelect.Id);
            IEnumerable<Dentist> UnavailableDentist = getBooked
                .Select(book => book.Dentist)
                .ToList(); 
            dentists = dentists.Except(UnavailableDentist).ToList();
            return dentists;
        }
        public int Tes(int id, int cid, DateTime? selectedDate)
        {
            IEnumerable<Appointment> getBooked = appointmentRepository.GetAppointmentByDateAndTimeSlot((DateTime)selectedDate, id, cid);
            return getBooked.Count();
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
            return list.Where(a => a.Dentist.User.Name.ToLower().Contains(search) || a.Service.Name.ToLower().Contains(search) || a.Date == (searchDate)).ToList();
        }

        public void DeleteAppointment(int id)
        {
            appointmentRepository.DeleteAppointmentById(id);
        }
    }
}
