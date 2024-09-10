using System.Windows;

namespace CMCSAPP_PROTOTYPE
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenSubmitClaimWindow_Click(object sender, RoutedEventArgs e)
        {
            SubmitClaimWindow submitClaimWindow = new SubmitClaimWindow();
            submitClaimWindow.Show();
        }

        private void OpenManageClaimsWindow_Click(object sender, RoutedEventArgs e)
        {
            ManageClaimsWindow manageClaimsWindow = new ManageClaimsWindow();
            manageClaimsWindow.Show();
        }

        private void OpenUploadDocumentsWindow_Click(object sender, RoutedEventArgs e)
        {
            UploadDocumentsWindow uploadDocumentsWindow = new UploadDocumentsWindow();
            uploadDocumentsWindow.Show();
        }

        private void OpenTrackStatusWindow_Click(object sender, RoutedEventArgs e)
        {
            TrackStatusWindow trackStatusWindow = new TrackStatusWindow();
            trackStatusWindow.Show();
        }
    }
}

