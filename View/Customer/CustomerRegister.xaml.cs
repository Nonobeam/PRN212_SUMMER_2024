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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using View.Component;

namespace View.Customer
{
    /// <summary>
    /// Interaction logic for CustomerRegister.xaml
    /// </summary>
    public partial class CustomerRegister : Window
    {
        private UserService userService;

        public CustomerRegister()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(username!= null && mail != null && phone !=null && password !=null && confirmPassword != null)
            {
                if (confirmPassword != password)
                {
                    if (!IsExistByMailOrPhone(mail,phone))
                    {
                        User customer = new User();
                        customer.Name = username.Text;
                        customer.Email = mail.Text;
                        customer.Phone = phone.Text;
                        customer.Password = password.Password;
                        customer.UserType = "Customer";
                        userService = UserService.GetInstance();
                        userService.AddUser(customer);
                        MessageBox.Show("Create Account successfully");
                        this.Close();
                        Login login = new Login();
                        login.Show();
                    }
                    else MessageBox.Show("Mail already exist account int he system");
                }
                else MessageBox.Show("Confirm Password isn't matched");
            } else
            {
                MessageBox.Show("You should input all required fields");
            }
        }

        private bool IsExistByMailOrPhone(TextBox mail, TextBox phone)
        {
            userService = UserService.GetInstance();
            if (userService.EmailExists(mail.Text) || userService.PhoneExists(phone.Text))
            {
                return true;
            }
            else
            {
                 return false;
            }
        }
    }
}
