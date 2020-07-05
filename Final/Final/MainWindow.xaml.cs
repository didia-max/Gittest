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
using System.Security.Cryptography;
namespace Final
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string a = tb1.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

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

        private void Button_Click_1(object sender, RoutedEventArgs e) //登录
        {
            if (rb1.IsChecked == true)
            {
                using (Database1Entities context = new Database1Entities())
                {
                    var q = from t in context.User
                            where tb1.Text == t.userid
                            select new
                            {
                                t.userpwd
                            };
                    foreach (var v in q)
                    {
                        string user = MD5Encrypt(pb1.Password);
                        if (user == v.userpwd)
                        {
                            this.Hide();
                            user = tb1.Text;
                            Userlogin userlogin = new Userlogin(user);
                            userlogin.ShowDialog();

                            return;
                        }
                    }
                    pb1.Clear();
                    MessageBox.Show("用户名或密码错误");

                }
            }
            else if (rb2.IsChecked == true)
            {
                using (Database1Entities context = new Database1Entities())
                {
                    var q = from t in context.Manager
                            where tb1.Text == t.managerid
                            select new
                            {
                                t.managerpwd
                            };
                    foreach (var v in q)
                    {
                        string user = MD5Encrypt(pb1.Password);
                        if (user == v.managerpwd)
                        {
                            this.Hide();
                            user = tb1.Text;
                            Managerlogin managerlogin = new Managerlogin(user);
                            managerlogin.ShowDialog();
                            this.Show();
                            return;
                        }
                    }
                    pb1.Clear();
                    MessageBox.Show("管理员用户名或密码错误");
                }
            }
            else { MessageBox.Show("请先选择登陆身份"); }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //忘记密码
        {
            Forgetpwd forgetpwd = new Forgetpwd();

            forgetpwd.ShowDialog();
        }
        public string MD5Encrypt(string password)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] hashedDataBytes;
            hashedDataBytes = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder tmp = new StringBuilder();
            foreach (byte i in hashedDataBytes)
            {
                tmp.Append(i.ToString("x2"));
            }
            return tmp.ToString();
        }

       
    }

}
