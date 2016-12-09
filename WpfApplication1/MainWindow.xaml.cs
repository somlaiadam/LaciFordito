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

namespace WpfApplication1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string s= textBox.Text.Replace("r", "l");
            textBox1.Text = s.Replace("R", "L");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string c = textBox.Text.Replace("l", "r");
            textBox1.Text = c.Replace("L", "R");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/somlaiadam/Laci_Fordito/tree/Hivatalos");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            string tb11 = textBox.Text.Replace("r", "l");
            string tb12 = tb11.Replace("R", "L");
            textBox1.Text = tb12;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            string tb21 = textBox.Text.Replace("l", "r");
            string tb22 = tb21.Replace("L", "R");
            textBox1.Text = tb22;
        }
    }
}
