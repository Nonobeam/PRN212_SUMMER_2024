using Data.Entities;
using Service;
using System.Windows;
using View.Component;

namespace View.Admin
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        private AppointmentService appointmentService;

        public Dashboard()
        {
            InitializeComponent();
            appointmentService = new();
            IEnumerable<Appointment> appointments = appointmentService.GetAllAppointments();

            DataContext = new DashboardViewModel(appointments);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Login login = new();
            login.Show();
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

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            ManageAccount account = new ManageAccount();
            account.Show();
            this.Close();
        }
    }
}
