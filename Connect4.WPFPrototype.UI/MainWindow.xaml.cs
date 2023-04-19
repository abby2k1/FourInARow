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

namespace Connect4.WPFPrototype.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] values = new string[156];
        public MainWindow()
        {
            InitializeComponent();
            ClearAll();
        }

        private void ClearAll()
        {
            for (int i = 0; i < 156; i++) 
            {
                values[i] = "0";
            }
            rec44.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec43.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec42.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec41.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec40.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec39.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec56.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec55.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec54.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec53.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec52.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec51.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec68.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec67.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec66.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec65.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec64.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec63.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec80.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec79.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec78.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec77.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec76.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec75.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec92.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec91.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec90.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec89.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec88.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec87.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec104.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec103.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec102.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec101.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec100.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec99.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec116.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec115.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec114.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec113.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec112.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec111.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void CheckWinner()
        {
            for (int i = 39; i < 117; i++) 
            {
                string winner = values[i];
                if ((values[i] == "1" && values[i+1] == "1" && values[i+2] == "1" && values[i+3] == "1") || (values[i] == "2" && values[i + 1] == "2" && values[i + 2] == "2" && values[i + 3] == "2"))
                {                   
                    WasWinner(winner);
                    ClearAll();
                }
                if ((values[i] == "1" && values[i + 13] == "1" && values[i + 26] == "1" && values[i + 39] == "1") || (values[i] == "2" && values[i + 13] == "2" && values[i + 26] == "2" && values[i + 39] == "2"))
                {
                    WasWinner(winner);
                    ClearAll();
                }
                if ((values[i] == "1" && values[i + 12] == "1" && values[i + 24] == "1" && values[i + 36] == "1") || (values[i] == "2" && values[i + 12] == "2" && values[i + 24] == "2" && values[i + 36] == "2"))
                {
                    WasWinner(winner);
                    ClearAll();
                }
                if ((values[i] == "1" && values[i + 11] == "1" && values[i + 22] == "1" && values[i + 33] == "1") || (values[i] == "2" && values[i + 11] == "2" && values[i + 22] == "2" && values[i + 33] == "2"))
                {
                    WasWinner(winner);
                    ClearAll();
                }
                //if ((values[i] == "1" && values[i - 1] == "1" && values[i - 2] == "1" && values[i - 3] == "1") || (values[i] == "2" && values[i - 1] == "2" && values[i - 2] == "2" && values[i - 3] == "2"))
                //{
                //    MessageBox.Show("WINNER!!!");
                //    ClearAll();
                //}
                //if ((values[i] == "1" && values[i - 13] == "1" && values[i - 26] == "1" && values[i - 39] == "1") || (values[i] == "2" && values[i - 13] == "2" && values[i - 26] == "2" && values[i - 39] == "2"))
                //{
                //    MessageBox.Show("WINNER!!!");
                //    ClearAll();
                //}
                //if ((values[i] == "1" && values[i - 12] == "1" && values[i - 24] == "1" && values[i - 36] == "1") || (values[i] == "2" && values[i - 12] == "2" && values[i - 24] == "2" && values[i - 36] == "2"))
                //{
                //    MessageBox.Show("WINNER!!!");
                //    ClearAll();
                //}
                //if ((values[i] == "1" && values[i - 11] == "1" && values[i - 22] == "1" && values[i - 33] == "1") || (values[i] == "2" && values[i - 11] == "2" && values[i - 22] == "2" && values[i - 33] == "2"))
                //{
                //    MessageBox.Show("WINNER!!!");
                //    ClearAll();
                //}
            }
        }

        private void WasWinner(string winner)
        {
            if (winner == "1")
                MessageBox.Show("Player 1 WINNER!!!"); 
            else
                MessageBox.Show("Player 2 WINNER!!!");
        }

        private void btnColumn1_Click(object sender, RoutedEventArgs e)
        {
            rec44.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[44] = "1";
        }

        private void btnX44_Click(object sender, RoutedEventArgs e)
        {
            rec44.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[44] = "1";
            CheckWinner();
        }

        private void btnO44_Click(object sender, RoutedEventArgs e)
        {
            rec44.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[44] = "2";
            CheckWinner();
        }

        private void btnX43_Click(object sender, RoutedEventArgs e)
        {
            rec43.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[43] = "1";
            CheckWinner();
        }

        private void btnO43_Click(object sender, RoutedEventArgs e)
        {
            rec43.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[43] = "2";
            CheckWinner();
        }

        private void btnX42_Click(object sender, RoutedEventArgs e)
        {
            rec42.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[42] = "1";
            CheckWinner();
        }

        private void btnO42_Click(object sender, RoutedEventArgs e)
        {
            rec42.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[42] = "2";
            CheckWinner();
        }

        private void btnX41_Click(object sender, RoutedEventArgs e)
        {
            rec41.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[41] = "1";
            CheckWinner();
        }

        private void btnO41_Click(object sender, RoutedEventArgs e)
        {
            rec41.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[41] = "2";
            CheckWinner();
        }

        private void btnX40_Click(object sender, RoutedEventArgs e)
        {
            rec40.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[40] = "1";
            CheckWinner();
        }

        private void btnO40_Click(object sender, RoutedEventArgs e)
        {
            rec40.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[40] = "2";
            CheckWinner();
        }

        private void btnX39_Click(object sender, RoutedEventArgs e)
        {
            rec39.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[39] = "1";
            CheckWinner();
        }

        private void btnO39_Click(object sender, RoutedEventArgs e)
        {
            rec39.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[39] = "2";
            CheckWinner();
        }

        private void btnX56_Click(object sender, RoutedEventArgs e)
        {
            rec56.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[56] = "1";
            CheckWinner();
        }

        private void btnO56_Click(object sender, RoutedEventArgs e)
        {
            rec56.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[56] = "2";
            CheckWinner();
        }

        private void btnX55_Click(object sender, RoutedEventArgs e)
        {
            rec55.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[55] = "1";
            CheckWinner();
        }

        private void btnO55_Click(object sender, RoutedEventArgs e)
        {
            rec55.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[55] = "2";
            CheckWinner();
        }

        private void btnX54_Click(object sender, RoutedEventArgs e)
        {
            rec54.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[54] = "1";
            CheckWinner();
        }

        private void btnO54_Click(object sender, RoutedEventArgs e)
        {
            rec54.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[54] = "2";
            CheckWinner();
        }

        private void btnX53_Click(object sender, RoutedEventArgs e)
        {
            rec53.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[53] = "1";
            CheckWinner();
        }

        private void btnO53_Click(object sender, RoutedEventArgs e)
        {
            rec53.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[53] = "2";
            CheckWinner();
        }

        private void btnX52_Click(object sender, RoutedEventArgs e)
        {
            rec52.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[52] = "1";
            CheckWinner();
        }

        private void btnO52_Click(object sender, RoutedEventArgs e)
        {
            rec52.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[52] = "2";
            CheckWinner();
        }

        private void btnX51_Click(object sender, RoutedEventArgs e)
        {
            rec51.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[51] = "1";
            CheckWinner();
        }

        private void btnO51_Click(object sender, RoutedEventArgs e)
        {
            rec51.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[51] = "2";
            CheckWinner();
        }

        private void btnX68_Click(object sender, RoutedEventArgs e)
        {
            rec68.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[68] = "1";
            CheckWinner();
        }

        private void btnO68_Click(object sender, RoutedEventArgs e)
        {
            rec68.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[68] = "2";
            CheckWinner();
        }

        private void btnX67_Click(object sender, RoutedEventArgs e)
        {
            rec67.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[67] = "1";
            CheckWinner();
        }

        private void btnO67_Click(object sender, RoutedEventArgs e)
        {
            rec67.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[67] = "2";
            CheckWinner();
        }

        private void btnX66_Click(object sender, RoutedEventArgs e)
        {
            rec66.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[66] = "1";
            CheckWinner();
        }

        private void btnO66_Click(object sender, RoutedEventArgs e)
        {
            rec66.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[66] = "2";
            CheckWinner();
        }

        private void btnX65_Click(object sender, RoutedEventArgs e)
        {
            rec65.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[65] = "1";
            CheckWinner();
        }

        private void btnO65_Click(object sender, RoutedEventArgs e)
        {
            rec65.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[65] = "2";
            CheckWinner();
        }

        private void btnX64_Click(object sender, RoutedEventArgs e)
        {
            rec64.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[64] = "1";
            CheckWinner();
        }

        private void btnO64_Click(object sender, RoutedEventArgs e)
        {
            rec64.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[64] = "2";
            CheckWinner();
        }

        private void btnX63_Click(object sender, RoutedEventArgs e)
        {
            rec63.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[63] = "1";
            CheckWinner();
        }

        private void btnO63_Click(object sender, RoutedEventArgs e)
        {
            rec63.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[63] = "2";
            CheckWinner();
        }

        private void btnX80_Click(object sender, RoutedEventArgs e)
        {
            rec80.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[80] = "1";
            CheckWinner();
        }

        private void btnO80_Click(object sender, RoutedEventArgs e)
        {
            rec80.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[80] = "2";
            CheckWinner();
        }

        private void btnX79_Click(object sender, RoutedEventArgs e)
        {
            rec79.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[79] = "1";
            CheckWinner();
        }

        private void btnO79_Click(object sender, RoutedEventArgs e)
        {
            rec79.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[79] = "2";
            CheckWinner();
        }

        private void btnX78_Click(object sender, RoutedEventArgs e)
        {
            rec78.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[78] = "1";
            CheckWinner();
        }

        private void btnO78_Click(object sender, RoutedEventArgs e)
        {
            rec78.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[78] = "2";
            CheckWinner();
        }

        private void btnX77_Click(object sender, RoutedEventArgs e)
        {
            rec77.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[77] = "1";
            CheckWinner();
        }

        private void btnO77_Click(object sender, RoutedEventArgs e)
        {
            rec77.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[77] = "2";
            CheckWinner();
        }

        private void btnX76_Click(object sender, RoutedEventArgs e)
        {
            rec76.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[76] = "1";
            CheckWinner();
        }

        private void btnO76_Click(object sender, RoutedEventArgs e)
        {
            rec76.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[76] = "2";
            CheckWinner();
        }

        private void btnX75_Click(object sender, RoutedEventArgs e)
        {
            rec75.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[75] = "1";
            CheckWinner();
        }

        private void btnO75_Click(object sender, RoutedEventArgs e)
        {
            rec75.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[75] = "2";
            CheckWinner();
        }

        private void btnX92_Click(object sender, RoutedEventArgs e)
        {
            rec92.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[92] = "1";
            CheckWinner();
        }

        private void btnO92_Click(object sender, RoutedEventArgs e)
        {
            rec92.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[92] = "2";
            CheckWinner();
        }

        private void btnX91_Click(object sender, RoutedEventArgs e)
        {
            rec91.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[91] = "1";
            CheckWinner();
        }

        private void btnO91_Click(object sender, RoutedEventArgs e)
        {
            rec91.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[91] = "2";
            CheckWinner();
        }

        private void btnX90_Click(object sender, RoutedEventArgs e)
        {
            rec90.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[90] = "1";
            CheckWinner();
        }

        private void btnO90_Click(object sender, RoutedEventArgs e)
        {
            rec90.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[90] = "2";
            CheckWinner();
        }

        private void btnX89_Click(object sender, RoutedEventArgs e)
        {
            rec89.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[89] = "1";
            CheckWinner();
        }

        private void btnO89_Click(object sender, RoutedEventArgs e)
        {
            rec89.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[89] = "2";
            CheckWinner();
        }

        private void btnX88_Click(object sender, RoutedEventArgs e)
        {
            rec88.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[88] = "1";
            CheckWinner();
        }

        private void btnO88_Click(object sender, RoutedEventArgs e)
        {
            rec88.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[88] = "2";
            CheckWinner();
        }

        private void btnX87_Click(object sender, RoutedEventArgs e)
        {
            rec87.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[87] = "1";
            CheckWinner();
        }

        private void btnO87_Click(object sender, RoutedEventArgs e)
        {
            rec87.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[87] = "2";
            CheckWinner();
        }

        private void btnX104_Click(object sender, RoutedEventArgs e)
        {
            rec104.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[104] = "1";
            CheckWinner();
        }

        private void btnO104_Click(object sender, RoutedEventArgs e)
        {
            rec104.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[104] = "2";
            CheckWinner();
        }

        private void btnX103_Click(object sender, RoutedEventArgs e)
        {
            rec103.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[103] = "1";
            CheckWinner();
        }

        private void btnO103_Click(object sender, RoutedEventArgs e)
        {
            rec103.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[103] = "2";
            CheckWinner();
        }

        private void btnX102_Click(object sender, RoutedEventArgs e)
        {
            rec102.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[102] = "1";
            CheckWinner();
        }

        private void btnO102_Click(object sender, RoutedEventArgs e)
        {
            rec102.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[102] = "2";
            CheckWinner();
        }

        private void btnX101_Click(object sender, RoutedEventArgs e)
        {
            rec101.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[101] = "1";
            CheckWinner();
        }

        private void btnO101_Click(object sender, RoutedEventArgs e)
        {
            rec101.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[101] = "2";
            CheckWinner();
        }

        private void btnX100_Click(object sender, RoutedEventArgs e)
        {
            rec100.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[100] = "1";
            CheckWinner();
        }

        private void btnO100_Click(object sender, RoutedEventArgs e)
        {
            rec100.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[100] = "2";
            CheckWinner();
        }

        private void btnX99_Click(object sender, RoutedEventArgs e)
        {
            rec99.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[99] = "1";
            CheckWinner();
        }

        private void btnO99_Click(object sender, RoutedEventArgs e)
        {
            rec99.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[99] = "2";
            CheckWinner();
        }

        private void btnX116_Click(object sender, RoutedEventArgs e)
        {
            rec116.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[116] = "1";
            CheckWinner();
        }

        private void btnO116_Click(object sender, RoutedEventArgs e)
        {
            rec116.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[116] = "2";
            CheckWinner();
        }

        private void btnX115_Click(object sender, RoutedEventArgs e)
        {
            rec115.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[115] = "1";
            CheckWinner();
        }

        private void btnO115_Click(object sender, RoutedEventArgs e)
        {
            rec115.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[115] = "2";
            CheckWinner();
        }

        private void btnX114_Click(object sender, RoutedEventArgs e)
        {
            rec114.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[114] = "1";
            CheckWinner();
        }

        private void btnO114_Click(object sender, RoutedEventArgs e)
        {
            rec114.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[114] = "2";
            CheckWinner();
        }

        private void btnX113_Click(object sender, RoutedEventArgs e)
        {
            rec113.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[113] = "1";
            CheckWinner();
        }

        private void btnO113_Click(object sender, RoutedEventArgs e)
        {
            rec113.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[113] = "2";
            CheckWinner();
        }

        private void btnX112_Click(object sender, RoutedEventArgs e)
        {
            rec112.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[112] = "1";
            CheckWinner();
        }

        private void btnO112_Click(object sender, RoutedEventArgs e)
        {
            rec112.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[112] = "2";
            CheckWinner();
        }

        private void btnX111_Click(object sender, RoutedEventArgs e)
        {
            rec111.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            values[111] = "1";
            CheckWinner();
        }

        private void btnO111_Click(object sender, RoutedEventArgs e)
        {
            rec111.Fill = new SolidColorBrush(Color.FromRgb(255, 165, 0));
            values[111] = "2";
            CheckWinner();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
        }
    }
}
