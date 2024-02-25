using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB_2_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> Users { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Users = new ObservableCollection<User>();
            userListView.ItemsSource = Users;
        }
   
        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Имя не может быть пустым.");
                return;
            }

            if (!int.TryParse(ageTextBox.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Возраст должен быть положительным числом.");
                return;
            }

            Users.Add(new User { Name = nameTextBox.Text, Age = age });
            nameTextBox.Text = "";
            ageTextBox.Text = "";
        }
    }
    public class User
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}

