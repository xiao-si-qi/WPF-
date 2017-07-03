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

namespace WPF窗体_hello_world
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
   
 public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
 
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;
            timer.Start();
          
         
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
         timeText.Text = DateTime.Now.ToString();
          

        }
        bool i = false  ;
        private void stop_Click(object sender, RoutedEventArgs e)
        {
          
          timeText .Text = "停止";
            if(i==false)
            { i = !i;
                timer.Stop();
                stop.Content = "开始";
            }
            else
            { timer.Start();
                i = !i;
                stop.Content = "停止";

            }
         
        }
    }
}
