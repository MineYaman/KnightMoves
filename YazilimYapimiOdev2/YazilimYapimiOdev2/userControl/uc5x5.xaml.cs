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

namespace YazilimYapimiOdev2.userControl
{
    /// <summary>
    /// Interaction logic for uc5x5.xaml
    /// </summary>
    public partial class uc5x5 : UserControl
    {
        public uc5x5()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button.Background = Brushes.Orange;
            button7.Background = Brushes.LightPink;
            button11.Background = Brushes.LightPink;
            button.Content = sayac;
            button.IsEnabled = false;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button2.Background = Brushes.Orange;
            button9.Background = Brushes.LightPink;
            button11.Background = Brushes.LightPink;
            button5.Background = Brushes.LightPink;
            button13.Background = Brushes.LightPink;
            button2.Content = sayac;
            button2.IsEnabled = false;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button3.Background = Brushes.Orange;
            button6.Background = Brushes.LightPink;
            button12.Background = Brushes.LightPink;
            button14.Background = Brushes.LightPink;
            button3.Content = sayac;
            button3.IsEnabled = false;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button4.Background = Brushes.Orange;
            button7.Background = Brushes.LightPink;
            button13.Background = Brushes.LightPink;
            button4.Content = sayac;
            button4.IsEnabled = false;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button5.Background = Brushes.Orange;
            button2.Background = Brushes.LightPink;
            button12.Background = Brushes.LightPink;
            button16.Background = Brushes.LightPink;
            button5.Content = sayac;
            button5.IsEnabled = false;

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button6.Background = Brushes.Orange;
            button3.Background = Brushes.LightPink;
            button13.Background = Brushes.LightPink;
            button17.Background = Brushes.LightPink;
            button15.Background = Brushes.LightPink;
            button6.Content = sayac;
            button6.IsEnabled = false;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button7.Background = Brushes.Orange;
            button.Background = Brushes.LightPink;
            button14.Background = Brushes.LightPink;
            button4.Background = Brushes.LightPink;
            button10.Background = Brushes.LightPink;
            button18.Background = Brushes.LightPink;
            button16.Background = Brushes.LightPink;
            button7.Content = sayac;
            button7.IsEnabled = false;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button8.Background = Brushes.Orange;
            button1.Background = Brushes.LightPink;
            button11.Background = Brushes.LightPink;
            button17.Background = Brushes.LightPink;
            button19.Background = Brushes.LightPink;
            button8.Content = sayac;
            button8.IsEnabled = false;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button9.Background = Brushes.Orange;
            button2.Background = Brushes.LightPink;
            button12.Background = Brushes.LightPink;
            button18.Background = Brushes.LightPink;
            button9.Content = sayac;
            button9.IsEnabled = false;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button10.Background = Brushes.Orange;
            button7.Background = Brushes.LightPink;
            button1.Background = Brushes.LightPink;
            button17.Background = Brushes.LightPink;
            button21.Background = Brushes.LightPink;
            button10.Content = sayac;
            button10.IsEnabled = false;
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button11.Background = Brushes.Orange;
            button.Background = Brushes.LightPink;
            button2.Background = Brushes.LightPink;
            button8.Background = Brushes.LightPink;
            button22.Background = Brushes.LightPink;
            button18.Background = Brushes.LightPink;
            button20.Background = Brushes.LightPink;
            button11.Content = sayac;
            button11.IsEnabled = false;

        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button12.Background = Brushes.Orange;
            button1.Background = Brushes.LightPink;
            button5.Background = Brushes.LightPink;
            button3.Background = Brushes.LightPink;
            button9.Background = Brushes.LightPink;
            button19.Background = Brushes.LightPink;
            button21.Background = Brushes.LightPink;
            button15.Background = Brushes.LightPink;
            button23.Background = Brushes.LightPink;
            button12.Content = sayac;
            button12.IsEnabled = false;
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button13.Background = Brushes.Orange;
            button4.Background = Brushes.LightPink;
            button2.Background = Brushes.LightPink;
            button6.Background = Brushes.LightPink;
            button16.Background = Brushes.LightPink;
            button22.Background = Brushes.LightPink;
            button24.Background = Brushes.LightPink;
            button13.Content = sayac;
            button13.IsEnabled = false;
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button14.Background = Brushes.Orange;
            button7.Background = Brushes.LightPink;
            button3.Background = Brushes.LightPink;
            button17.Background = Brushes.LightPink;
            button23.Background = Brushes.LightPink;
            button14.Content = sayac;
            button14.IsEnabled = false;
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button15.Background = Brushes.Orange;
            button6.Background = Brushes.LightPink;
            button12.Background = Brushes.LightPink;
            button22.Background = Brushes.LightPink;
            button15.Content = sayac;
            button15.IsEnabled = false;
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button16.Background = Brushes.Orange;
            button5.Background = Brushes.LightPink;
            button7.Background = Brushes.LightPink;
            button13.Background = Brushes.LightPink;
            button23.Background = Brushes.LightPink;
            button16.Content = sayac;
            button16.IsEnabled = false;

        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button17.Background = Brushes.Orange;
            button6.Background = Brushes.LightPink;
            button14.Background = Brushes.LightPink;
            button8.Background = Brushes.LightPink;
            button10.Background = Brushes.LightPink;
            button20.Background = Brushes.LightPink;
            button24.Background = Brushes.LightPink;
            button17.Content = sayac;
            button17.IsEnabled = false;
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button18.Background = Brushes.Orange;
            button11.Background = Brushes.LightPink;
            button7.Background = Brushes.LightPink;
            button9.Background = Brushes.LightPink;
            button21.Background = Brushes.LightPink;
            button18.Content = sayac;
            button18.IsEnabled = false;
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button19.Background = Brushes.Orange;
            button8.Background = Brushes.LightPink;
            button12.Background = Brushes.LightPink;
            button22.Background = Brushes.LightPink;
            button19.Content = sayac;
            button19.IsEnabled = false;

        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button20.Background = Brushes.Orange;
            button11.Background = Brushes.LightPink;
            button17.Background = Brushes.LightPink;
            button20.Content = sayac;
            button20.IsEnabled = false;
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button21.Background = Brushes.Orange;
            button10.Background = Brushes.LightPink;
            button12.Background = Brushes.LightPink;
            button18.Background = Brushes.LightPink;
            button21.Content = sayac;
            button21.IsEnabled = false;

        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button22.Background = Brushes.Orange;
            button11.Background = Brushes.LightPink;
            button13.Background = Brushes.LightPink;
            button15.Background = Brushes.LightPink;
            button19.Background = Brushes.LightPink;
            button22.Content = sayac;
            button22.IsEnabled = false;

        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button23.Background = Brushes.Orange;
            button12.Background = Brushes.LightPink;
            button14.Background = Brushes.LightPink;
            button16.Background = Brushes.LightPink;
            button23.Content = sayac;
            button23.IsEnabled = false;

        }

        private void button24_Click(object sender, RoutedEventArgs e)
        {
            sayac++;
            button24.Background = Brushes.Orange;
            button13.Background = Brushes.LightPink;
            button17.Background = Brushes.LightPink;
            button24.Content = sayac;
            button24.IsEnabled = false;
            if (sayac == 25)
            {
                MessageBox.Show("YOU WIN!");
            }
        



        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            sayac++;
            button1.Background = Brushes.Orange;
            button8.Background = Brushes.LightPink;
            button12.Background = Brushes.LightPink;
            button10.Background = Brushes.LightPink;
            button1.Content = sayac;
            button1.IsEnabled = false;

        }
        
      

    }
}
