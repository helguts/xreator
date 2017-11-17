using Microsoft.Win32;
using System.IO;
using System.Windows;
using XreatorApp.parser;

namespace XreatorApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLoadXSD_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xsd files (*.xsd)|*.xsd";
            if (openFileDialog.ShowDialog() == true)
            {
                Parser parser = new Parser();
                parser.ParseFile(openFileDialog.FileName);
                MessageBox.Show(Path.GetFileName(openFileDialog.FileName) + " geparst.", "XSD geparst");
            }

        }
    }
}
