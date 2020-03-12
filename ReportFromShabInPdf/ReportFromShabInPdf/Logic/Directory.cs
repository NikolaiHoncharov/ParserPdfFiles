using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReportFromShabInPdf.Logic
{
    public class Directory
    {
        public DirectoryInfo dirInfo { get; set; }
        public string path { get; set; }
        public string subpath { get; set; }

        public Directory()
        {
            this.path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            this.subpath = @"ReportsFromShab";
            this.dirInfo = new DirectoryInfo(path + "\\" + subpath);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }


        public string CreateFolder(string DateStart, string DateEnd)
        {
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory($"{DateStart}-{DateEnd}");
            return dirInfo.ToString() + "\\" + $"{DateStart}-{DateEnd}";
        }



        public void DeleteFile(string pathfile)
        {
            try
            {
                File.Delete(pathfile);
            }
            catch (Exception)
            {
                MessageBox.Show("Not delete","Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
