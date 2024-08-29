using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSimpleGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = textBox3.Text;
            textBox3.Text = textBox4.Text;
            textBox4.Text = temp;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void scrollDownButton_Click(object sender, RoutedEventArgs e)
        {
            string temp = textBox4.Text;
            textBox4.Text = textBox3.Text;
            textBox3.Text = textBox2.Text;
            textBox2.Text = textBox1.Text;
            textBox1.Text = temp;
          
        }


    }
}