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

namespace Final_Project
{
    /// <summary>
    /// UserControl1.xaml 的互動邏輯
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private int _stake;
        private int _round;
        private int _time;
        private int _level;
        private Window1 _window;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).Content =
                Application.Current.Resources["MainWinContent"];
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            _level = 1;
            _stake = 20;
            _round = 5;
            _time = 7;
            _window = new Window1(_level, _stake, _round, _time);
            _window.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            _level = 2;
            _stake = 30;
            _round = 6;
            _time = 6;
            _window = new Window1(_level, _stake, _round, _time);
            _window.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            
            _level = 3;
            _stake = 40;
            _round = 7;
            _time = 5;
            _window = new Window1(_level, _stake, _round, _time);
            _window.Show();
        }

    }
}
