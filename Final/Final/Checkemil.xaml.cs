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
    /// Checkemil.xaml 的交互逻辑
    /// </summary>
    public partial class Checkemil : Window
    {
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        public Checkemil(string emil)
        {
            InitializeComponent();
            Database1Entities c = new Database1Entities();
            var q = from t in c.User
                    where emil == t.email
                    select t;

            foreach (var v in q)
            {

                v.userpwd = MD5Encrypt("123");
                tb1.Text = "已经发送一封验证邮件到您的邮箱" + emil + "中，请注意查收";
            }
            c.SaveChanges();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(4);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("验证成功！您的密码已经重置为: 123");
            timer.Stop();
            this.Close();
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
