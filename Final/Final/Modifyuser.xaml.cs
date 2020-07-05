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
    /// Modifyuser.xaml 的交互逻辑
    /// </summary>
    public partial class Modifyuser : Window
    {
        public Modifyuser()
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
            Database1Entities c = new Database1Entities();
            var q = from t in c.User
                    where tb1.Text == t.userid
                    select t;

            foreach (var v in q)
            {
                string a = MD5Encrypt(pb1.Password);
                string newa = MD5Encrypt(pb2.Password);
                if (v.userpwd == a)
                {
                    v.userpwd = newa;
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("旧密码错误");
                }

            }
            
            c.SaveChanges();
            
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
