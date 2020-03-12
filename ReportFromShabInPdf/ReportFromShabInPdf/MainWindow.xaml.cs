using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace ReportFromShabInPdf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Parser parser;
        ReportFromShabInPdf.Logic.Directory directory;
        public MainWindow()
        {
            InitializeComponent();
            directory = new Logic.Directory();
            BuildTree();
        }

        private void BtnDownloadRp_Click(object sender, RoutedEventArgs e)
        {
            if(dateStart.SelectedDate!=null && dateEnd.SelectedDate!=null)
            {
                DateTime star = (DateTime)dateStart.SelectedDate;
                DateTime end = (DateTime)dateEnd.SelectedDate;

                this.parser = new Parser((star.Year + "-" + star.Month + "-" + star.Day), (end.Year + "-" + end.Month + "-" + end.Day));
                parser.DonloadPage();
                parser.DonloadFilePdf();
                BuildTree();
            }
            else
            {
                MessageBox.Show("Select Start and End date", "Attention", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
        }




        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure to close the application?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes) this.Close();

        }

        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }






        private void BuildTree()
        {
            treeFileSystem.Items.Clear();
            DriveInfo.GetDrives();
            foreach (var drive in directory.dirInfo.GetDirectories())
            {
                TreeViewItem item = new TreeViewItem();
                item.Tag = drive;
                item.Header = drive.ToString();

                // * отображаться не будет, так как узел находится в закрытом состоянии,
                item.Items.Add("*");
                treeFileSystem.Items.Add(item);
            }
        }

        private void item_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)e.OriginalSource;

            // выполняем обновление каждый раз, когда узел разворачивается.
            item.Items.Clear();

            DirectoryInfo dir;
            try
            {
                if (item.Tag is DriveInfo)
                {
                    DriveInfo drive = (DriveInfo)item.Tag;
                    dir = drive.RootDirectory;
                }
                else
                {
                    dir = (DirectoryInfo)item.Tag;
                }


                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    TreeViewItem newItem = new TreeViewItem();
                    newItem.Tag = subDir;
                    newItem.Header = subDir.ToString();
                    newItem.Items.Add("*");
                    item.Items.Add(newItem);
                }
                foreach (FileInfo subDir in dir.GetFiles())
                {
                    TreeViewItem newItem = new TreeViewItem();
                    newItem.Tag = subDir;
                    newItem.Header = subDir.ToString();
                    //newItem.Items.Add("*");
                    item.Items.Add(newItem);
                }
            }
            catch
            {
               
            }
        }

        private void treeFileSystem_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TreeViewItem item = treeFileSystem.SelectedItem as TreeViewItem;
            if (item != null)
            {
                DirectoryInfo dirInfo = item.Tag as DirectoryInfo;
                

                if (dirInfo != null)
                    Title = dirInfo.FullName;
                else
                {
                    FileInfo fileingo = item.Tag as FileInfo;
                    MessageBoxResult result = MessageBox.Show("Open this file?", "Open file", MessageBoxButton.YesNo, MessageBoxImage.Information);
                    if (result == MessageBoxResult.Yes)
                    {
                        System.Diagnostics.Process.Start(fileingo.FullName);
                    }
                }

                
            }
        }

        private void treeFileSystem_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
           //var t =  (TreeViewItem)treeFileSystem.SelectedItem;
           //if(t.Header.ToString().IndexOf(".pdf")>=0)
           //{

           //}
           // try
           // {

           //     var item = (e.NewValue as TreeViewItem);
           //     if (item.Items.Count > 0)
           //     {
           //         (item.Items[0] as TreeViewItem).IsSelected = true;
           //     }

           //     if (item.Header != null)
           //     {
           //         var s = directory.dirInfo;
           //         var files = Directory.EnumerateFiles(directory.dirInfo + "\\", item.Header.ToString(), SearchOption.AllDirectories);
           //         var dir = files.FirstOrDefault().ToString();
           //         var file = new FileInfo(dir);
           //         file.Delete();

           //     }

           // }
           // catch (Exception)
           // {  }

        }

        private void treeFileSystem_KeyDown(object sender, KeyEventArgs e)
        {
            if(Key.Delete == e.Key && treeFileSystem.SelectedItem != null)
            {
                try
                { 
                    var item = (TreeViewItem)treeFileSystem.SelectedItem;
                    if (item.Header != null && item.Header.ToString().IndexOf(".pdf") >= 0)
                    {
                        var s = directory.dirInfo;
                        var files = Directory.EnumerateFiles(directory.dirInfo + "\\", item.Header.ToString(), SearchOption.AllDirectories);
                        var dir = files.FirstOrDefault().ToString();
                        MessageBoxResult result = MessageBox.Show("Delete this file?", "Delete file", MessageBoxButton.YesNo, MessageBoxImage.Information);
                        if (result == MessageBoxResult.Yes)
                        {
                            directory.DeleteFile(dir);
                        }
                    }
                }
                catch (Exception)
                { }
            }
        }
    }
}
