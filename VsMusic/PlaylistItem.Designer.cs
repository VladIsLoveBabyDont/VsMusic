namespace VsMusic
{
    partial class PlaylistItem
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.playlistArea = new System.Windows.Forms.TableLayoutPanel();
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.titleArea = new System.Windows.Forms.TableLayoutPanel();
            this.description = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.playlistArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.titleArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // playlistArea
            // 
            this.playlistArea.BackColor = System.Drawing.Color.Transparent;
            this.playlistArea.ColumnCount = 2;
            this.playlistArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.playlistArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playlistArea.Controls.Add(this.picAlbum, 0, 0);
            this.playlistArea.Controls.Add(this.titleArea, 1, 0);
            this.playlistArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlistArea.Location = new System.Drawing.Point(10, 10);
            this.playlistArea.Name = "playlistArea";
            this.playlistArea.RowCount = 1;
            this.playlistArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playlistArea.Size = new System.Drawing.Size(280, 60);
            this.playlistArea.TabIndex = 0;
            // 
            // picAlbum
            // 
            this.picAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAlbum.Image = global::VsMusic.Properties.Resources.albom;
            this.picAlbum.Location = new System.Drawing.Point(3, 3);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(54, 54);
            this.picAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlbum.TabIndex = 0;
            this.picAlbum.TabStop = false;
            // 
            // titleArea
            // 
            this.titleArea.ColumnCount = 1;
            this.titleArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titleArea.Controls.Add(this.description, 0, 1);
            this.titleArea.Controls.Add(this.title, 0, 0);
            this.titleArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleArea.Location = new System.Drawing.Point(60, 0);
            this.titleArea.Margin = new System.Windows.Forms.Padding(0);
            this.titleArea.Name = "titleArea";
            this.titleArea.RowCount = 2;
            this.titleArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titleArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titleArea.Size = new System.Drawing.Size(220, 60);
            this.titleArea.TabIndex = 1;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.description.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.description.ForeColor = System.Drawing.Color.Silver;
            this.description.Location = new System.Drawing.Point(3, 30);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(214, 30);
            this.description.TabIndex = 1;
            this.description.Text = "description";
            this.description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(214, 30);
            this.title.TabIndex = 0;
            this.title.Text = "title";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.playlistArea);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PlaylistItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(300, 80);
            this.playlistArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.titleArea.ResumeLayout(false);
            this.titleArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel playlistArea;
        private PictureBox picAlbum;
        private TableLayoutPanel titleArea;
        private Label description;
        private Label title;
    }
}
