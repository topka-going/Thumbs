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
using System.Windows.Threading;

namespace Thumbs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer datimer = new DispatcherTimer();
            datimer.Tick += new EventHandler(UpdateTimer_Tick);
            datimer.Interval = new TimeSpan(0, 0, 1);
            datimer.Start();
        }

        public void UpdateTimer_Tick(object sender,EventArgs e)
        {
            DateTime date1 = new DateTime(2021, 11, 24, 6, 0, 0);
            var date = date1 - DateTime.Now;
            FooTime.Text = $"{date.Days} дней {date.Hours} часов и {date.Minutes} минут";
        }



        

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

            Window6 win6 = new Window6();
            win6.ShowDialog();

        }
    }
}
