using System.Windows;
using System.Windows.Controls;
using Data.Entities;
using Data.Repository;
using Service;
using View.Component;

namespace View.DentistPage
{
    public partial class DentistAppointmentHistory : Window
    {
        private readonly AppointmentService _appointmentService;
        private readonly CustomerService _customerService;
        private readonly TimeSlotService _timeSlotService;
        private readonly ServiceService _serviceService;
        private readonly ClinicService _clinicService;
        private readonly UserService _userService;

        private User currentDentist;

        public DentistAppointmentHistory(User dentist)
        {
            InitializeComponent();
            currentDentist = dentist;
            
            _appointmentService = new AppointmentService();
            _timeSlotService = new TimeSlotService();
            _customerService = new CustomerService();
            _serviceService = new ServiceService();
            _userService = new UserService();
            _clinicService = new ClinicService();

            LoadData();
        }

        private void LoadData()
        {
            IEnumerable<Appointment> appointments = _appointmentService.GetAppointmentsByDentist(currentDentist.Id);

            var customers = _customerService.GetAllCustomers().ToDictionary(c => c.Id);
            var timeSlots = _timeSlotService.GetAllTimeSlots().ToDictionary(t => t.Id);
            var services = _serviceService.GetAllServices().ToDictionary(s => s.Id);
            var clinics = _clinicService.GetAllClinics().ToDictionary(c => c.Id);
            var users = _userService.GetAllUsers().ToDictionary(u => u.Id);

            var displayAppointments = appointments.Select(a => new
            {
                Date = a.Date?.ToString("yyyy-MM-dd") ?? "",
                TimeSlot = a.TimeSlotId.HasValue && timeSlots.ContainsKey(a.TimeSlotId.Value) ? timeSlots[a.TimeSlotId.Value].Time?.ToString("HH:mm") ?? "" : "",
                Customer = a.CustomerId.HasValue && customers.ContainsKey(a.CustomerId.Value) ? customers[a.CustomerId.Value].Name : "",
                Dentist = a.DentistId.HasValue && users.ContainsKey(a.DentistId.Value) ? users[a.DentistId.Value].Name : "", // Assuming the UserId is stored in DentistId
                Service = a.ServiceId.HasValue && services.ContainsKey(a.ServiceId.Value) ? services[a.ServiceId.Value].Name : "",
                Clinic = a.ClinicId.HasValue && clinics.ContainsKey(a.ClinicId.Value) ? clinics[a.ClinicId.Value].Address : ""
            }).ToList();

            AccountTable.ItemsSource = displayAppointments;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime? searchDateValue = string.IsNullOrEmpty(searchDate.Text) ? (DateTime?)null : DateTime.Parse(searchDate.Text);
            string searchNameValue = searchName.Text.ToLower();

            IEnumerable<Appointment> appointments = _appointmentService.GetAppointmentsByDentist(currentDentist.Id);

            var customers = _customerService.GetAllCustomers().ToDictionary(c => c.Id);
            var timeSlots = _timeSlotService.GetAllTimeSlots().ToDictionary(t => t.Id);
            var services = _serviceService.GetAllServices().ToDictionary(s => s.Id);
            var clinics = _clinicService.GetAllClinics().ToDictionary(c => c.Id);
            var users = _userService.GetAllUsers()
                        .Where(u => u.Name.ToLower().Contains(searchNameValue.ToLower()))
                        .ToDictionary(u => u.Id);

            var filteredAppointments = appointments.Where(a =>
                (!searchDateValue.HasValue || a.Date == searchDateValue.Value)
            ).Select(a => new
            {
                Date = a.Date?.ToString("yyyy-MM-dd") ?? "",
                TimeSlot = a.TimeSlotId.HasValue && timeSlots.ContainsKey(a.TimeSlotId.Value) ? timeSlots[a.TimeSlotId.Value].Time?.ToString("HH:mm") ?? "" : "",
                Customer = a.CustomerId.HasValue && customers.ContainsKey(a.CustomerId.Value) ? customers[a.CustomerId.Value].Name : "",
                Dentist = a.DentistId.HasValue && users.ContainsKey(a.DentistId.Value) ? users[a.DentistId.Value].Name : "", // Assuming the UserId is stored in DentistId
                Service = a.ServiceId.HasValue && services.ContainsKey(a.ServiceId.Value) ? services[a.ServiceId.Value].Name : "",
                Clinic = a.ClinicId.HasValue && clinics.ContainsKey(a.ClinicId.Value) ? clinics[a.ClinicId.Value].Address : ""
            }).ToList();

            AccountTable.ItemsSource = filteredAppointments;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Appointment_Click(object sender, RoutedEventArgs e)
        {
            AppointmentWeek appointmentWeek = new AppointmentWeek(currentDentist);
            appointmentWeek.Show();
            this.Close();
        }
    }
}
