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

namespace shavuha
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

        private void to_shav_Checked(object sender, RoutedEventArgs e)
        {
            how_text.Text = "Кол-во рублей";
        }

        private void to_rub_Checked(object sender, RoutedEventArgs e)
        {
            how_text.Text = "Кол-во шавух";
        }

        private void final_button_Click(object sender, RoutedEventArgs e)
        {
            if(to_rub.IsChecked == true)
            {
                MessageBox.Show(Convert.ToString(Convert.ToInt32(how_box.Text) * Convert.ToInt32(money_box.Text)));
            }
            else if(to_shav.IsChecked == true)
            {

            }
        }
    }
}
