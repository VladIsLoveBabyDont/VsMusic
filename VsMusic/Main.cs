using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VsMusic
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            trackBar1.PlayPause += TrackBar1_PlayPause;
            trackBar1.PlayNext += TrackBar1_PlayNext;
            trackBar1.PlayPrevios += TrackBar1_PlayPrevios;

        }
        
        private void TrackBar1_PlayPrevios(object? sender, EventArgs e)
        {
            int index = musicArea.Controls.IndexOf(play);
            if(index == 0)
            {
                index = musicArea.Controls.Count;
            }

            Control nextTrack = musicArea.Controls[index - 1];
            NewTrack_MusicPlay(nextTrack, e);
        }

        private void TrackBar1_PlayNext(object? sender, EventArgs e)
        {
            int index = musicArea.Controls.IndexOf(play);
            if(index + 1 == musicArea.Controls.Count)
            {
                index = -1;
            }

            Control nextTrack = musicArea.Controls[index + 1];
            NewTrack_MusicPlay(nextTrack, e);
        }

        private void TrackBar1_PlayPause(object? sender, EventArgs e)
        {
            bool player = (bool)sender;
            if(player)
            {
                play.ButtonPlay = false;
            }
            else
            {
                play.ButtonPlay = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string[] dirs = Directory.GetDirectories("./Music");
            foreach(string dir in dirs)
            {
                
                PlaylistItem platList = new PlaylistItem();
                DirectoryInfo direcory = new DirectoryInfo(dir);
                platList.Title = direcory.Name;
                platList.Description = direcory.CreationTime.ToString("dd MMMM ❤ yyyy");
                platList.FilePath = direcory.FullName;
                platList.PlaylistChanged += PlatList_PlaylistChanged;

                string image = Path.Combine(dir, "index.jpg");
                if (File.Exists(image))
                {
                    Bitmap bitmap = new Bitmap(image);
                    platList.PlaylistImage = bitmap;
                }

                playListArea.Controls.Add(platList);
            }


            PlaylistItem? playlist = playListArea.Controls[0] as PlaylistItem;
            if(playlist != null)
            {
                ShowPlayList(playlist);
            }
        }

        private void PlatList_PlaylistChanged(object? sender, EventArgs e)
        {
            PlaylistItem? playlist = sender as PlaylistItem;
            if (playlist != null)
            {
                ShowPlayList(playlist);
            }
        }

        public void ShowPlayList(PlaylistItem playList)
        {
            musicArea.Controls.Clear();

            string[] files = Directory.GetFiles(playList.FilePath, "*.mp3");

            foreach (var musicTrack in files)
            {
                FileInfo file = new FileInfo(musicTrack);
                MusicItem newTrack = new MusicItem();
                newTrack.Title = file.Name.Replace(".mp3", "");
                newTrack.Description = playList.Title;
                newTrack.FilePath = file.FullName;
                newTrack.MusicPlay += NewTrack_MusicPlay;
                newTrack.MusicHover += NewTrack_MusicHover;
                newTrack.TrackImage = playList.PlaylistImage;

                musicArea.Controls.Add(newTrack);
            }
        }

        MusicItem hover;
        private void NewTrack_MusicHover(object? sender, EventArgs e)
        {
            if (sender is MusicItem musicItem && hover != musicItem)
            {
                if (hover != null )
                {
                    hover.ButtonVisible = false;
                }
                hover = musicItem;
                hover.ButtonVisible = true;
            }
        }

        MusicItem play;
        private void NewTrack_MusicPlay(object? sender, EventArgs e)
        {
            if(sender is MusicItem musicItem)
            {
                if(play == musicItem)
                {
                    trackBar1.PlayPauseClick(sender, e);
                }
                else
                {
                    if (play != null)
                    {
                        play.ButtonPlay = false;
                    }
                    play = musicItem;
                    play.ButtonPlay = true;
                    trackBar1.Play(play.FilePath);
                }
            }
            
        }
    }
}