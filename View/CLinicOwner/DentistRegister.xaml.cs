using Data.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace View.CLinicOwner
{
    /// <summary>
    /// Interaction logic for DentistRegister.xaml
    /// </summary>
    public partial class DentistRegister : Window
    {
        private DentistService dentistService;
        private UserService userService;
        private ClinicService clinicService;
        private int id;
        public DentistRegister()
        {
            InitializeComponent();
            cbStatus.ItemsSource = new List<string> { "Active", "Inactive" };
            cbStatus.SelectedIndex = 0;
            clinicService = new ClinicService();
            List<Clinic> list = clinicService.GetAllClinics().ToList();
            foreach (Clinic clinic in list)
            {
                ComboBoxItem item = new ComboBoxItem
                {
                    Content = clinic.Name,
                    Tag = clinic.Id
                };
                cbClinic.Items.Add(item);
            }
            cbClinic.SelectedIndex = 0;
            dentistService = new DentistService();
            userService = new UserService();
        }

        public DentistRegister(int id)
        {
            InitializeComponent();
            cbStatus.ItemsSource = new List<string> { "Active", "Inactive" };
            this.id = id;
            clinicService = new ClinicService();
            List<Clinic> list = clinicService.GetAllClinics().ToList();
            foreach (Clinic clinic in list)
            {
                ComboBoxItem item = new ComboBoxItem
                {
                    Content = clinic.Name,
                    Tag = clinic.Id
                };
                cbClinic.Items.Add(item);
            }
            dentistService = new DentistService();
            userService = new UserService();
            User user = userService.GetUserById(id);
            txtName.Text= user.Name;
            txtPhone.Text = user.Phone;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            cbStatus.SelectedIndex = user.Available;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string userType = "Dentist";
            User user = new User();
            user.Name = name;
            user.Phone = phone;
            user.Email = email;
            user.Password = password;
            user.UserType = userType;
            string status = cbStatus.Text;
            int available = 0;
            if (status == "Active")
            {
                available = 1;
            }
            user.Available = available;
            if (name == null || name.Length == 0 || email == null || email.Length == 0 ||
                phone == null || phone.Length == 0 || password == null || password.Length == 0
                )
            {
                txtError.Text = "Please complete all field!";
            }
            else
            {
                try
                {
                    User? userInDB = userService.GetUserById(this.id);
                    if (userInDB != null)
                    {
                        Dentist dentist = new Dentist();
                        dentist.UserId = userInDB.Id;
                        int selectedClinicId = 0;
                        if (cbClinic.SelectedItem is ComboBoxItem selectedItem)
                        {
                            selectedClinicId = (int)selectedItem.Tag;
                        }
                        dentist.ClinicId = selectedClinicId;
                            dentistService.UpdateDentist
                                (dentist);

                    }
                    else
                    {
                        Dentist dentist = new Dentist();
                        userService.AddUser(user);
                        User? userEmail = userService.getUserByEmail(user.Email);
                        dentist.UserId = userEmail.Id;
                        int selectedClinicId = 0;
                        if (cbClinic.SelectedItem is ComboBoxItem selectedItem)
                        {
                            selectedClinicId = (int)selectedItem.Tag;
                        }
                        dentist.ClinicId = selectedClinicId;
                        dentistService.AddDentist
                            (dentist);

                    }
                    DentistManagement management = new DentistManagement();
                    management.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    txtError.Text = "Cannot add new Dentist";
                }

            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DentistManagement dentistManagement = new DentistManagement();
            dentistManagement.Show();
            this.Close();
        }
    }
}
