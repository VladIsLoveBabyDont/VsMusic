using System.ComponentModel;

namespace VsMusic
{
    public partial class PlaylistItem : UserControl
    {
        public PlaylistItem()
        {
            InitializeComponent();
            RecursiveHendlerHover(this);
            RecursiveHendlerDoubleClick(this);
        }
        public event EventHandler PlaylistChanged;


        #region Рекурсивне наведення
        void RecursiveHendlerHover(Control element)
        {
            element.MouseEnter += Element_MouseEnter;
            element.MouseLeave += Element_MouseLeave;

            foreach (Control innerElement in element.Controls)
            {
                RecursiveHendlerHover(innerElement);
            }
        }
        private void Element_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(50, 50, 50);
        }
        private void Element_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(40, 40, 40);
        }
        #endregion
        #region Рекурсивне подвійне натиснення
        void RecursiveHendlerDoubleClick(Control element)
        {
            element.MouseDoubleClick += Element_MouseDoubleClick;

            foreach (Control innerElement in element.Controls)
            {
                RecursiveHendlerDoubleClick(innerElement);
            }
        }

        private void Element_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            PlaylistChanged.Invoke(this, e);
        }
        #endregion
        #region Кастомні властивості
        [Category("Властивості плейлиста")]
        public string Title
        {
            get
            {
                return title.Text;
            }
            set
            {
                title.Text = value;
            }
        }

        [Category("Властивості плейлиста")]
        public string Description
        {
            get { return description.Text; }
            set { description.Text = value; }
        }

        string filePath;
        [Category("Властивості плейлиста")]
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        [Category("Властивості плейлиста")]
        public Image PlaylistImage
        {
            get
            {
                return picAlbum.Image;
            }
            set
            {
                picAlbum.Image = value;
            }
        }
        #endregion
    }
}
