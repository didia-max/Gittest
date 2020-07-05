using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Final
{
    class WordToPdf
    {
        public static bool WordToPDF(string sourcePath)
        {
            bool result = false;
            Application application = new Application();
            Document document = null;
            try
            {
                application.Visible = false;
                document = application.Documents.Open(sourcePath);
                string doc = "";

                for (int i = sourcePath.Length - 4; i < sourcePath.Length; i++)
                {
                    doc += sourcePath.ElementAt(i);
                }
                string PDFPath = "";
                if (doc == "docx")
                {
                    PDFPath = sourcePath.Replace(".docx", ".pdf");
                }
                else
                {
                    PDFPath = sourcePath.Replace(".doc", ".pdf");
                }
                if (!File.Exists(@PDFPath))
                {
                    document.ExportAsFixedFormat(PDFPath, WdExportFormat.wdExportFormatPDF);
                }
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }
            finally
            {
                document.Close();
            }
            return result;
        }

        public static string ReadWord(string path)
        {
            Application application = new Application();
            Document document = application.Documents.Open(path);
            string content = "";

            int sentencesLength = document.Paragraphs.Count;

            for (int sen = 1; sen <= sentencesLength; sen++)
            {
                content += document.Paragraphs[sen].Range.Text;
                content += '\n';
            }

            return content;
        }
    }

}

