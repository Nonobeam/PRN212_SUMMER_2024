using Data.Entities;
using Microsoft.VisualBasic.ApplicationServices;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace View.CLinicOwner
{
    /// <summary>
    /// Interaction logic for CustomerManagement.xaml
    /// </summary>
    public partial class CustomerManagement : Window
    {
        private CustomerService customerService;
        private UserService userService;
        public CustomerManagement()
        {
            InitializeComponent();
            customerService = new CustomerService();
            userService = new UserService();
            List<Data.Entities.User> list = customerService.GetAllCustomers().ToList();
            tbCustomer.Items.Clear();
            tbCustomer.ItemsSource = list;
            cbStatus.ItemsSource   = new List<string> { "Active", "Inactive" };
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String id = txtId.Text;

            string name = txtName.Text;
            string phone = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string userType = "Customer";
            Data.Entities.User user = new Data.Entities.User();

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
            try
            {
                if (id != "")
                {
                    user.Id = int.Parse(id);
                    
                }
                userService.AddUser(user);
                txtId.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtPassword.Text = "";
            }
            catch (Exception ex)
            {
                txtError.Text = "Cannot add new User!";
            }
            List<Data.Entities.User> list = customerService.GetAllCustomers().ToList();
            tbCustomer.ItemsSource = list;
        }

        private void cbStatus1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
                Button button = sender as Button;
                int id = (int)button.Tag;
            Data.Entities.User user = userService.GetUserById(id);
                if(user != null)
                {
                txtId.Text = user.Id + "";
                txtName.Text = user.Name;
                txtEmail.Text = user.Email;
                txtPhone.Text = user.Phone;
                txtPassword.Text = user.Password;
                cbStatus.SelectedIndex = user.Available;
                }
               
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
        }
    }
}
