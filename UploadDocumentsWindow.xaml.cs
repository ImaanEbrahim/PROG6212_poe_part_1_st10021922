using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using Microsoft.Win32;

namespace CMCSAPP_PROTOTYPE
{
    public partial class UploadDocumentsWindow : Window
    {
        public UploadDocumentsWindow()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Handle file selection
                MessageBox.Show($"Selected file: {openFileDialog.FileName}");
            }
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            // Upload logic
            MessageBox.Show("Document uploaded successfully!");
        }
    }
}

