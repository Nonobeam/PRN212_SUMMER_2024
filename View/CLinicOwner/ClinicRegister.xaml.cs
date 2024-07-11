using Data.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace View.CLinicOwner
{
    /// <summary>
    /// Interaction logic for ClinicRegister.xaml
    /// </summary>
    public partial class ClinicRegister : Window
    {
        private ClinicService clinicService;
        public ClinicRegister()
        {
            InitializeComponent();
            cbAvailable.ItemsSource = new List<string> { "Active", "Inactive" };
            cbAvailable.SelectedIndex = 0;
            clinicService = new ClinicService();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string managerId = txtManagerId.Text;

            if(name == null || name.Length == 0 || address == null || address.Length == 0 || 
                phone == null || phone.Length ==0 || managerId == null || managerId.Length == 0 ) {
                txtError.Text = "Please complete all field!";
            }
            else
            {
                Clinic clinic = new Clinic();
                clinic.Name = name;
                clinic.Address = address;
                clinic.Phone = phone;
                int id = int.Parse(managerId);
                clinic.ManagerId = id;
                string status = cbAvailable.Text;
                int available = 0;
                if(status == "Active")
                {
                    available = 1;
                }
                clinic.Available = available;
                try
                {
                    clinicService.AddClinic(clinic);
                }catch(Exception ex)
                {
                    txtError.Text = ex.Message;
                }
               
            }
        }
    }
}
