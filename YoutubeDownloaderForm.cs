using YoutubeDownloader.Services;

namespace YoutubeDownloader
{
    public partial class YoutubeDownloaderForm : Form
    {
        private IDownloadService _downloadService;

        public YoutubeDownloaderForm(IDownloadService downloadService)
        {
            _downloadService = downloadService;
            InitializeComponent();
        }

        private void YoutubeDownloaderInterface_Load(object sender, EventArgs e)
        {

        }

        private void btnDownloadMp3_Click(object sender, EventArgs e)
        {
            var youtubeLink = txtBoxYoutubeLink.Text;
            _downloadService.DownloadMp3(youtubeLink);
        }

        private void btnChangeFilePath_Click(object sender, EventArgs e)
        {
            var downloadPath = txtboxFilePath.Text;
            YoutubeDownloader.Properties.Settings.Default.DownloadPath = downloadPath;
            YoutubeDownloader.Properties.Settings.Default.Save();
            txtboxFilePath.Text = downloadPath;
        }

        private void btnDownloadMp4_Click(object sender, EventArgs e)
        {
            var youtubeLink = txtBoxYoutubeLink.Text;
            _downloadService.DownloadMp4(youtubeLink);
        }
    }
}