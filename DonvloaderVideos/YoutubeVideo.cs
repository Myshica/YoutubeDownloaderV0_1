using AngleSharp.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using VideoLibrary;
using static System.Windows.Forms.LinkLabel;

namespace DonvloaderVideos
{
    public class YoutubeVideo
    {
        public YouTube youtube = YouTube.Default;
        public YouTubeVideo video;
        public ProgressBar progress;
        string videoUrl, idVideo;
        string savePath;
        public Image videoImage;
        public string titleVideo;
        public string authorVideo;
        public string durationVideo;
        public string[] resulutionVideo;
        public string sizeVideo;
        public string getMbytesVideo;

        public YoutubeVideo(string url, ProgressBar progress)
        {
            this.videoUrl = url;
            this.progress = progress;
            this.savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public YoutubeVideo(string url, string path, ProgressBar progress)
        {
            this.videoUrl = url;
            this.progress = progress;
            this.savePath = path;
        }


        public void Initialize()
        {
            video = youtube.GetVideo(videoUrl);
            GetInfoVideo();
        }


        public void GetInfoVideo()
        {
            titleVideo = video.Title;
            authorVideo = video.Info.Author;
            durationVideo = getDuration(video.Info.LengthSeconds.Value);
            var videoInfos = youtube.GetAllVideosAsync(videoUrl).GetAwaiter().GetResult();
            var maxResolution = videoInfos.First(i => i.Resolution == videoInfos.Max(j => j.Resolution));
            idVideo = getId();
            videoImage = getImage(idVideo);

        }

        public string getDuration(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"hh\:mm\:ss");
        }


        public string getId()
        {
            var uri = new Uri(this.videoUrl);
            var query = HttpUtility.ParseQueryString(uri.Query);
            var videoId = string.Empty;
            if (query.AllKeys.Contains("v"))
            {
                videoId = query["v"];
            }
            else
            {
                videoId = uri.Segments.Last();
            }
            return videoId;
        }

        public Image getImage(string id)
        {
            WebClient cli = new WebClient();
            string url_image = $"https://img.youtube.com/vi/{id}/mqdefault.jpg";
            byte[] bytes = cli.DownloadData(url_image);

            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
            ms.Write(bytes, 0, bytes.Length);
            return Image.FromStream(ms, true);
        }
    }
}
