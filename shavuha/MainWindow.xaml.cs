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

            float money_int;
            float how_int;

            if (to_rub.IsChecked == true)
            {
                if(float.TryParse(how_box.Text, out how_int) && float.TryParse(money_box.Text, out money_int))
                {
                    MessageBox.Show(Convert.ToString(how_int * money_int) + " рублей");
                }
                else
                {
                    MessageBox.Show("Неккоректный ввод");
                }
            }
            else if(to_shav.IsChecked == true)
            {
                if (float.TryParse(how_box.Text, out how_int) && float.TryParse(money_box.Text, out money_int))
                {
                    MessageBox.Show(Convert.ToString( how_int / money_int ) + " шавух");
                }
                else
                {
                    MessageBox.Show("Неккоректный ввод");
                }
            }
        }
    }
}
