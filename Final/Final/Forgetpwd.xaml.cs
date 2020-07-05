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
using System.Windows.Shapes;

namespace Final
{
    /// <summary>
    /// Forgetpwd.xaml 的交互逻辑
    /// </summary>
    public partial class Forgetpwd : Window
    {
        public Forgetpwd()
        {
            InitializeComponent();
        }
        private void Min_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void WindowsMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                try
                {
                    DragMove();
                }
                catch { }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) //
        {
            Checkemil checkemil = new Checkemil(tb1.Text);
            this.Hide();
            checkemil.ShowDialog();
        }
    }
}
