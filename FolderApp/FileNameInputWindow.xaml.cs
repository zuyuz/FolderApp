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

namespace FolderApp
{
    /// <summary>
    /// Interaction logic for FileNameInputWindow.xaml
    /// </summary>
    public partial class FileNameInputWindow : Window
    {
        string path;

        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }

        public FileNameInputWindow()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxFileName.Text == string.Empty)
            {
                MessageBox.Show("Enter file name to continue");
            }
            else
            {
                path = textBoxFileName.Text + ".dat";
                Close();
            }
        }
    }
}
