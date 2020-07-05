using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Createuser.xaml 的交互逻辑
    /// </summary>
    public partial class Createuser : Window
    {
        public Createuser()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pb1.Password == pb2.Password)
            {
                try
                {
                    User userInfo = new User();

                    userInfo.userid = tb1.Text;
                    userInfo.userpwd = MD5Encrypt(pb1.Password);
                    userInfo.email = tb2.Text;
                    userInfo.balance = 3;
                    Database1Entities con = new Database1Entities();

                    con.User.Add(userInfo);
                    con.SaveChanges();
                    MessageBox.Show("创建成功");

                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("创建失败，已存在用户");
                }
            }
            else
            {
                MessageBox.Show("两次密码输入不一致");
            }
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
