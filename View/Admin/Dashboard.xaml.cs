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
            ManageAccount manageAccount = new();
            manageAccount.Show();
            this.Close();
        }
    }
}
