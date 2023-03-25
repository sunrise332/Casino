using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Casino
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

        async private void Spin_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int one = 0, two = 0, three = 0;
            slotsResult.Content = $"$";
            for (int i = 0; i < 10; i++)
            {
                one = random.Next(10);
                win1.Content = one;
                await Task.Delay(300);
                   two = random.Next(10);
                win2.Content = two;
                await Task.Delay(300);
                    three= random.Next(10);
                win3.Content = three;
                await Task.Delay(300);
            }
            if (one != two && one != three && two != three)
            {
                slotsResult.Content = $"-100$";
            }
            else if (one == two && one == three)
            {
                slotsResult.Content = $"200$";
            }
            else if (one == two || one == three || two == three)
            {
                slotsResult.Content = $"50$";
            }
        }
         private void Spins()
        {
            Random random = new Random();
             for (int i = 0; i < 10; i++)
            {
                win1.Content = random.Next(10);
                Thread.Sleep(300);
                win2.Content = random.Next(10);
                Thread.Sleep(300);
                win3.Content = random.Next(10);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("https://vk.com/oryzieybral?z=photo367958441_457250803%2Falbum367958441_0%2Frev");
        }
    }
}
