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
    /// Managerlogin.xaml 的交互逻辑
    /// </summary>
    public partial class Managerlogin : Window
    {
        public Managerlogin(string user)
        {
           
            InitializeComponent();
            tb1.Text = "你好，管理员：" + user;

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

        private void Button_Click_2(object sender, RoutedEventArgs e) //注册用户
        {
            Createuser createuser = new Createuser();

            createuser.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //注册管理员
        {
            Createmanager createmanager = new Createmanager();

            createmanager.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //修改用户密码
        {
            Modifyuser modifyuser = new Modifyuser();

            modifyuser.ShowDialog();
        }
    }
}
