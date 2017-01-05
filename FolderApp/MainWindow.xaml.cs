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
using System.Windows.Forms;
using System.IO;

namespace FolderApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void buttonPack_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.Desktop;
            dialog.Description = "Select folder to pack:";
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();

            string selectedPath = dialog.SelectedPath;

            if (selectedPath != string.Empty)
            {
                FolderTree folderTree = new FolderTree(selectedPath);

                FolderManager.ProcessDirectory(selectedPath, folderTree);

                FileNameInputWindow window = new FileNameInputWindow();
                window.ShowDialog();
                if (window.Path != null)
                {
                    Serialization.Serialize(folderTree, window.Path);
                }
            }
        }

        private void buttonShowStructure_Click(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".dat"; // Default file extension
            dlg.Filter = "data documents (.dat)|*.dat"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
                var tree = Serialization.Deserialize(filename);

                if (treeView.Items.Count != 0)
                    treeView.Items.Remove(treeView.Items[0]);
                TreeViewItem item = new TreeViewItem();
                item.Tag = tree;
                item.Header = tree.Path.Split('\\').Last();
                item.Items.Add("*");
                treeView.Items.Add(item);
            }
        }

        private void TreeViewExpanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)e.OriginalSource;
            item.Items.Clear();
            FolderTree folder = (FolderTree)item.Tag;

            try
            {
                // With each file
                //foreach (var el in (item.Tag as FolderTree).SubFiles)
                //{
                //    TreeViewItem newItem = new TreeViewItem();
                //    newItem.Tag = el;
                //    newItem.Header = el.Path.Split('\\').Last();
                //    newItem.Items.Add("*");
                //    item.Items.Add(newItem);
                //}

                foreach (var el in (item.Tag as FolderTree).SubFolders)
                {
                    TreeViewItem newItem = new TreeViewItem();
                    newItem.Tag = el;
                    newItem.Header = el.Path.Split('\\').Last();
                    newItem.Items.Add("*");
                    item.Items.Add(newItem);
                }
            }
            catch
            { }
        }

        private void buttonUnpack_Click(object sender, RoutedEventArgs e)
        {
            if (treeView.SelectedItem != null)
            {
                var dialog = new System.Windows.Forms.FolderBrowserDialog();
                dialog.RootFolder = Environment.SpecialFolder.Desktop;
                dialog.Description = "Select folder to unpack into:";
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                string selectedPath = dialog.SelectedPath + '\\';


                var treeItem = (treeView.SelectedItem as TreeViewItem);
                if (treeItem.Tag is File)
                {

                }
                else if (treeItem.Tag is FolderTree)
                {
                    string rootDir = selectedPath;
                    FolderTree folder = treeItem.Tag as FolderTree;
                    WriteToFileGivenFolderTree(folder, rootDir);
                    //
                }
                //System.IO.File.WriteAllBytes("new.docx", tmp);
            }
        }

        private void WriteToFileGivenFolderTree(FolderTree fTree, string path)
        {
            path += fTree.Path.Split('\\').Last() + '\\';
            Directory.CreateDirectory(path);

            foreach (var i in fTree.SubFiles)
            {
                System.IO.File.WriteAllBytes(path + '\\' + i.Path.Split('\\').Last(), i.FileInBytes);
            }

            foreach (var i in fTree.SubFolders)
            {
                WriteToFileGivenFolderTree(i, path);
            }
        }
    }
}
