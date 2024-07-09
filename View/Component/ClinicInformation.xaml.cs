using Data.Entities;
using Data.Repository;
using Microsoft.VisualBasic.ApplicationServices;
using OxyPlot.Series;
using Service;
using System.Collections.ObjectModel;
using System.Windows;
using View.Admin;

namespace View.Component
{
    public partial class ClinicInformation : Window
    {
        private readonly AppointmentService _appointmentService;
        private readonly ClinicService _clinicService;
        private readonly CustomerService _customerService;
        private readonly ServiceService _serviceService;
        private readonly TimeSlotService _timeSlotService;
        private readonly UserService _userService;

        private Clinic clinic;

        public ClinicInformation(int clinicId)
        {
            InitializeComponent();


            _appointmentService = new AppointmentService();
            _timeSlotService = new TimeSlotService();
            _customerService = new CustomerService();
            _serviceService = new ServiceService();
            _userService = new UserService();
            _clinicService = new ClinicService();

            clinic = _clinicService.GetClinicById(clinicId);

            LoadData(clinicId);
            DataContext = this;
        }

        private void LoadData(int clinicId)
        {
            IEnumerable<Appointment> appointments = _appointmentService.GetAppointmentsByClinicId(clinicId);

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


            DentistsTable.ItemsSource = _userService.GetDentistNameInOneClinic(clinicId);

            AppointmentsTable.ItemsSource = displayAppointments;
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            ManageAccount manageAccount = new ManageAccount();
            manageAccount.Show();
            this.Close();
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void Clinic_Click(object sender, RoutedEventArgs e)
        {
            ManageClinic manageClinic = new ManageClinic();
            manageClinic.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
