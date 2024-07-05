using Service;
using System.Windows;
using System.Text.RegularExpressions;
using User = Data.Entities.User;
using View.Component;

namespace View.Admin
{
    /// <summary>
    /// Interaction logic for ManageAccount.xaml
    /// </summary>
    public partial class ManageAccount : Window
    {
        private UserService userService;

        public ManageAccount()
        {
            InitializeComponent();
            userService = new UserService();
            AccountTable.ItemsSource = userService.GetAllUsers();
        }

        private void AccountTable_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (AccountTable.SelectedItem is User selected)
            {
                newName.Text = selected.Name;
                newEmail.Text = selected.Email;
                newPhone.Text = selected.Phone;
                newRole.Text = selected.UserType;
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string email = searchMail.Text.ToLower();
            string name = searchName.Text.ToLower();

            var filteredUsers = userService.GetAllUsers().Where(user =>
                (string.IsNullOrEmpty(email) || user.Email.ToLower().Contains(email)) &&
                (string.IsNullOrEmpty(name) || user.Name.ToLower().Contains(name)));

            RefreshAccountTable(filteredUsers);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (AccountTable.SelectedItem is User selected)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    if (selected.Available == 1)
                    {
                        userService.ChangeUserAvailable(selected.Id, 0);
                    }
                    else
                    {
                        MessageBox.Show("This account is already deleted.");
                    }

                    RefreshAccountTable();
                }
            } else
            {
                MessageBox.Show("Please choose an account.");
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string name = newName.Text.Trim();
            string phone = newPhone.Text.Trim();
            string role = newRole.Text.Trim();
            string email = newEmail.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (userService.EmailExists(email))
            {
                MessageBox.Show("Email already exists.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (userService.PhoneExists(phone))
            {
                MessageBox.Show("Phone number already exists.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            name = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

            User newUser = new User
            {
                Name = name,
                Phone = phone,
                Password = "123",
                UserType = role,
                Email = email,
                Available = 1 // assuming 1 means active
            };

            userService.AddUser(newUser);

            newName.Clear();
            newPhone.Clear();
            newRole.Clear();
            newEmail.Clear();

            MessageBox.Show("User added successfully. Please change the password as soon as possible. The default password is 123.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            RefreshAccountTable();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RefreshAccountTable(IEnumerable<User> users = null)
        {
            if (users == null)
            {
                AccountTable.ItemsSource = userService.GetAllUsers().ToList();
            }
            else
            {
                AccountTable.ItemsSource = users.ToList();
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
            ManageAccount account = new();
            account.Show();
            this.Close();
        }
    }
}
