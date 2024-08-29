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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;
        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();
            UpdateUI();
        }

        private void newPersonButton_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson();
            UpdateUI();
        }

        private void deletePersonButton_Click(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();
            UpdateUI();
        }

        private void upButton_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            UpdateUI();
        }

        private void downButton_Click(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
            UpdateUI();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.FirstName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.LastName = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(textBox3.Text, out int age);
            controller.CurrentPerson.Age = age;
        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.TelephoneNo = textBox4.Text;
        }


        private void UpdateUI()
        {
            if (controller.PersonCount == 0)
            {
                textBox1.IsEnabled = false;
                textBox2.IsEnabled = false;
                textBox3.IsEnabled = false;
                textBox4.IsEnabled = false;

                deletePersonButton.IsEnabled = false;
                upButton.IsEnabled = false;
                downButton.IsEnabled = false;
            }
            else
            {
                textBox1.IsEnabled = true;
                textBox2.IsEnabled = true;
                textBox3.IsEnabled = true;
                textBox4.IsEnabled = true;
                deletePersonButton.IsEnabled = true;
                upButton.IsEnabled = true;
                downButton.IsEnabled = true;

                personCountLabel.Content = $"Person Count {controller.PersonCount}";
                indexLabel.Content = $"Index {controller.PersonIndex}";
                textBox1.Text = controller.CurrentPerson.FirstName;
                textBox2.Text = controller.CurrentPerson.LastName;
                textBox3.Text = controller.CurrentPerson.Age.ToString();
                textBox4.Text = controller.CurrentPerson.TelephoneNo;
            }
        }


    }
}
