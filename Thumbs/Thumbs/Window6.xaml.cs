using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Thumbs
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();

            DispatcherTimer datimer = new DispatcherTimer();
            datimer.Tick += new EventHandler(main.UpdateTimer_Tick);
            datimer.Interval = new TimeSpan(0, 0, 1);
            datimer.Start();
            //FooTime6.Text = Convert.ToString(main.UpdateTimer_Tick);
        }
            MainWindow main = new MainWindow();


        private void Login_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
        }
    }
}
