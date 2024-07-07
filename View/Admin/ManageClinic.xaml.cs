using Service;
using System.Linq;
using System.Windows;
using System.Text.RegularExpressions;
using Clinic = Data.Entities.Clinic;
using View.Component;

namespace View.Admin
{
    /// <summary>
    /// Interaction logic for ManageClinic.xaml
    /// </summary>
    public partial class ManageClinic : Window
    {
        private ClinicService clinicService;

        public ManageClinic()
        {
            InitializeComponent();
            clinicService = new ClinicService();
            ClinicTable.ItemsSource = clinicService.GetAllClinics();
        }


        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string name = searchName.Text.ToLower();
            string address = searchAddress.Text.ToLower();

            var filteredClinics = clinicService.GetAllClinics().Where(clinic =>
                (string.IsNullOrEmpty(name) || clinic.Name.ToLower().Contains(name)) &&
                (string.IsNullOrEmpty(address) || clinic.Address.ToLower().Contains(address)));

            RefreshClinicTable(filteredClinics);
        }


        private void RefreshClinicTable(IEnumerable<Clinic> clinics = null)
        {
            if (clinics == null)
            {
                ClinicTable.ItemsSource = clinicService.GetAllClinics().ToList();
            }
            else
            {
                ClinicTable.ItemsSource = clinics.ToList();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Login login = new();
            login.Show();
            this.Close();
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new();
            dashboard.Show();
            this.Close();
        }


        private void Clinic_Click(object sender, RoutedEventArgs e)
        {
            ManageClinic clinic = new();
            clinic.Show();
            this.Close();
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            ManageAccount manageAccount = new ManageAccount();
            manageAccount.Show();
            this.Close();
        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            /*if (ClinicTable.SelectedItem is Clinic selectedClinic)
            {
                ClinicInformation clinicInformation = new(Clinic);
                clinicInformation.Show();
            }
            else
            {
                MessageBox.Show("Please se");
            }*/
        }
    }
}
