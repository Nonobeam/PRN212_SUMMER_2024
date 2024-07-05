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

        private void ClinicTable_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ClinicTable.SelectedItem is Clinic selected)
            {
                newName.Text = selected.Name;
                newPhone.Text = selected.Phone;
                newAddress.Text = selected.Address;
                newManagerId.Text = selected.ManagerId.ToString();
            }
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

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClinicTable.SelectedItem is Clinic selected)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this clinic?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    if (selected.Available == 1)
                    {
                        clinicService.ChangeClinicAvailable(selected.Id, 0);
                    }
                    else
                    {
                        MessageBox.Show("This clinic is already deleted.");
                    }

                    RefreshClinicTable();
                }
            }
            else
            {
                MessageBox.Show("Please choose a clinic.");
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string name = newName.Text.Trim();
            string phone = newPhone.Text.Trim();
            string address = newAddress.Text.Trim();
            string managerIdText = newManagerId.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(managerIdText))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!int.TryParse(managerIdText, out int managerId))
            {
                MessageBox.Show("Invalid manager ID.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Clinic newClinic = new Clinic
            {
                Name = name,
                Phone = phone,
                Address = address,
                ManagerId = managerId,
                Available = 1
            };

            clinicService.AddClinic(newClinic);

            newName.Clear();
            newPhone.Clear();
            newAddress.Clear();
            newManagerId.Clear();

            MessageBox.Show("Clinic added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            RefreshClinicTable();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Your update logic here
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

        private void back_Click(object sender, RoutedEventArgs e)
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
    }
}
