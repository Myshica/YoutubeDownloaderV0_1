using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Net.Http;
using ProgressBar = System.Windows.Forms.ProgressBar;
using System.Web.UI;

namespace DonvloaderVideos
{
    public partial class Form : System.Windows.Forms.Form
    {

        YoutubeVideo youtube = null;

        public Form()
        {
            InitializeComponent();
        }

        public async Task DownloadVideoAsync(string filename, string videoUri)
        {
            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Head, videoUri))
                {
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    long? totalBytes = response.Content.Headers.ContentLength;

                    using (Stream output = File.OpenWrite(filename))
                    {
                        using (var input = await client.GetStreamAsync(videoUri))
                        {
                            byte[] buffer = new byte[1024 * 1024];
                            int read;
                            long totalRead = 0;

                            while ((read = await input.ReadAsync(buffer, 0, buffer.Length)) > 0)
                            {
                                await output.WriteAsync(buffer, 0, read);
                                totalRead += read;

                                if (totalBytes.HasValue)
                                {
                                    int progressPercentage = (int)(((double)totalRead / totalBytes.Value) * 100);
                                    string value = $"{(totalRead / 1048576.0):0.00}/{(totalBytes.Value / 1048576.0):0.00} MB";
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        ProgressBar_Download.Value = progressPercentage;
                                        Size_File_Label.Text = value;
                                    });
                                }
                            }
                        }
                    }
                }
            }
        }


        private void Search_btn_Click(object sender, EventArgs e)
        {
            string url = Search_line.Text;
            if (url.Length > 0)
            {
                youtube = new YoutubeVideo(url, ProgressBar_Download);
                youtube.Initialize();

                Author_Video_Label.Text = youtube.authorVideo;
                Title_Video_text.Text = youtube.titleVideo;
                Video_Duration_Label.Text = youtube.durationVideo;
                Picture_Video_box.Image = youtube.videoImage;
            }
        }

        private async void Download_btn_Click(object sender, EventArgs e)
        {
            if (youtube != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Выберите куда сохранять видео";
                save.FileName = this.youtube.video.FullName;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    await Task.Run(async () =>
                    {
                        await DownloadVideoAsync(save.FileName, youtube.video.Uri);
                    });
                }
            }
            else
            {
                MessageBox.Show("Нажмите поиск!");
            }
        }


    }
}
