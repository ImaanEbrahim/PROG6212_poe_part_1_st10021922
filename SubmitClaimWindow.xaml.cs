using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;

namespace CMCSAPP_PROTOTYPE
{
    public partial class SubmitClaimWindow : Window
    {
        public SubmitClaimWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Submission logic
            MessageBox.Show("Claim submitted successfully!");
        }
    }
}

