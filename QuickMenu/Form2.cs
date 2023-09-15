using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsMediaController.MediaManager;
using Windows.Media.Control;
using System.Drawing;
using Windows.Storage.Streams;
using System.IO;
using System.Diagnostics;
using QuickMenu.Resources.Custom_Controls;
using System.Linq;

namespace QuickMenu
{
    public partial class TestPage : Form
    {
        public TestPage()
        {
            MediaSession mediaSession = Program.mediaManager.GetCurrentSession();
            if(mediaSession != null)
            {
                Program.mediaManager.GetCurrentSession().OnMediaPropertyChanged += UpdateInfo;
                Program.mediaManager.GetCurrentSession().OnTimelinePropertyChanged += UpdateTime;
            }
            Program.mediaManager.GetMediaManager().OnAnySessionClosed += UpdateSourceButtons;
            Program.mediaManager.GetMediaManager().OnAnySessionOpened += UpdateSourceButtons;
            InitializeComponent();
            UpdateInfo(null, null);
            UpdateSourceButtons(null);
            TopMost = true;
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await Program.mediaManager.GetCurrentSession()?.ControlSession.TrySkipNextAsync();
            });
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await Program.mediaManager.GetCurrentSession()?.ControlSession.TrySkipPreviousAsync();
            });
        }

        private void UpdateTime(MediaSession mediaSession, GlobalSystemMediaTransportControlsSessionTimelineProperties timelineProperties)
        {
            var progress = Program.mediaManager.GetCurrentSongTime();
            var totalDuration = Program.mediaManager.GetSongDuration();

            if (progress.TotalMilliseconds <= 0 || totalDuration.TotalMilliseconds <= 0)
            {
                return;
            }

            double progressPercentage = (progress.TotalMilliseconds / totalDuration.TotalMilliseconds) * 100.0;
            
            if(double.IsNaN(progressPercentage) || progressPercentage < 0 || progressPercentage > 100)
            {
                return;
            }

            if (InvokeRequired)
            {
                Invoke(new Action(() => SongProgress.Value = (int)progressPercentage));
            }
            else
            {

                SongProgress.Value = (int)progressPercentage;
            }
        }

        private async void UpdateInfo(MediaSession mediaSession, GlobalSystemMediaTransportControlsSessionMediaProperties mediaProperties)
        {
            var songname = Program.mediaManager.GetSongName();
            var artist = Program.mediaManager.GetSongArtist();;
            if (InvokeRequired)
            {
                Invoke(new Action(() => SongName.Text = songname));
                Invoke(new Action(() => Artist.Text = artist));
            }
            else
            {
                
                Artist.Text = artist;
                SongName.Text = songname;
            }

            IRandomAccessStreamReference streamRef = Program.mediaManager.GetSongImage();
            if (streamRef == null) return;
            IRandomAccessStream stream = await streamRef.OpenReadAsync();
            Stream streamToConvert = stream.AsStreamForRead();

            Image thumbnailImage = Image.FromStream(streamToConvert);

            Bitmap resizeImage = new(128, 128);

            using Graphics graphics = Graphics.FromImage(resizeImage);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphics.DrawImage(thumbnailImage, 0, 0, 128, 128);

            pictureBox2.Image = resizeImage;
            UpdateTime(null, null);
        }

        private void UpdateSourceButtons(MediaSession mediaSession)
        {
            var sessions = Program.mediaManager.GetMediaManager().CurrentMediaSessions.Values.ToList();
            MediaSession session = Program.mediaManager.GetCurrentSession();
            string sessionName = session == null ? "Unknown" : session.Id;
            if (InvokeRequired)
            {
                Invoke(new Action(() => SessionName.Text = Program.mediaManager.GetCurrentSession().Id));
                Invoke(new Action(() => SessionCount.Text = $"{sessions.IndexOf(session) + 1}/{sessions.Count}"));
            }
            else
            {
                SessionCount.Text = $"{sessions.IndexOf(session) + 1}/{sessions.Count}";
                SessionName.Text = sessionName.Replace(".exe", "");
            }
        }

        private long CalcPlaybackPosition(double length, double pos)
        {
            if(pos < 0.0)
            {
                pos = 0.0;
            }else if (pos > 100.0)
            {
                pos = 100.0;
            }

            double position = (length * pos) / 100;
            return (long)position;
        }

        private void SongProgress_Click(object sender, EventArgs ev)
        {
            MouseEventArgs e = (MouseEventArgs)ev;
            if (e.Button == MouseButtons.Left)
            {
                CustomProgressBar progressBar = (CustomProgressBar)sender;
                int totalWidth = progressBar.Width - progressBar.Padding.Left - progressBar.Padding.Right;
                int clickedX = e.X - progressBar.Padding.Left;
                int position = (int)((double)clickedX / totalWidth * progressBar.Maximum);
                Task.Run(async () =>
                {
                    await Program.mediaManager.GetCurrentSession()?.ControlSession.TryChangePlaybackPositionAsync(CalcPlaybackPosition(Program.mediaManager.GetSongDuration().TotalMilliseconds, position));
                });
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            Program.mediaManager.NextSession();
            UpdateSourceButtons(null);
            UpdateInfo(null, null);
        }

        private void PrevPage_Click(object sender, EventArgs e)
        {
            Program.mediaManager.PreviousSession();
            UpdateSourceButtons(null);
            UpdateInfo(null, null);
        }
    }
}
