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
using System.IO;
using System.Windows.Xps.Packaging;
using Microsoft.Office.Interop.Word;
using Microsoft.Win32;
using Window = System.Windows.Window;

namespace Final
{
    /// <summary>
    /// Userlogin.xaml 的交互逻辑
    /// </summary>
    public partial class Userlogin : Window
    {
        public Userlogin(string a)
        {
            InitializeComponent();
            lb2.Content = a;
            using (Database1Entities c = new Database1Entities())
            {                               
                var q = from t1 in c.User
                        where a == t1.userid
                        select new
                        {
                            t1.balance
                        };
               foreach(var v in q)
                {
                    lb1.Content = "尊敬的"+a+"，欢迎您，您的账户余额还有：" + v.balance + "个月";
                    
                }
                
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
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

        private void Button_Click_2(object sender, RoutedEventArgs e) //充值
        {
            using (Database1Entities c = new Database1Entities())
            {
                var q = from t2 in c.User
                        where lb2.Content == t2.userid
                        select t2;
                foreach (var v in q)
                {
                    int time;
                    int.TryParse(cb1.Text, out time);
                    v.balance += time;

                }
                c.SaveChanges();
                Czpicture czpicture = new Czpicture();
                czpicture.ShowDialog();
                foreach (var v in q)
                {
                    lb1.Content = "尊敬的" + lb2.Content + "，欢迎您，您的账户余额还有：" + v.balance+"个月";
                }
            }
            
            
        }
        public string FilePath { get; private set; }
        private void Button_Click_3(object sender, RoutedEventArgs e) //读取Word
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            FilePath = openFileDialog.FileName;
            if (FilePath != "")
            {
                docView.Document = WordShow.ConvertWordToXPS(FilePath).GetFixedDocumentSequence();
                docView.FitToWidth();
            }
            else
            {
                MessageBox.Show("No file selected");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) //保存为pdf
        {
            WordToPdf.WordToPDF(FilePath);
            string doc = "";
            for (int i = FilePath.Length - 4; i < FilePath.Length; i++)
            {
                doc += FilePath.ElementAt(i);
            }
            string PDFPath = "";
            if (doc == "docx")
            {
                PDFPath = FilePath.Replace(".docx", ".pdf");
            }
            else
            {
                PDFPath = FilePath.Replace(".doc", ".pdf");
            }
            MessageBox.Show("Successfully converted \n address" + PDFPath);
        }
    }


  
}
