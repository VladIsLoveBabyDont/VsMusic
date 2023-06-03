namespace VsMusic
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.musicArea = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBar1 = new VsMusic.MusicTrackBar();
            this.playListArea = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // musicArea
            // 
            this.musicArea.AutoScroll = true;
            this.musicArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicArea.Location = new System.Drawing.Point(300, 0);
            this.musicArea.Name = "musicArea";
            this.musicArea.Size = new System.Drawing.Size(1027, 616);
            this.musicArea.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar1.Location = new System.Drawing.Point(0, 616);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1327, 70);
            this.trackBar1.TabIndex = 0;
            // 
            // playListArea
            // 
            this.playListArea.AutoScroll = true;
            this.playListArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.playListArea.Location = new System.Drawing.Point(0, 0);
            this.playListArea.Name = "playListArea";
            this.playListArea.Size = new System.Drawing.Size(300, 616);
            this.playListArea.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1327, 686);
            this.Controls.Add(this.musicArea);
            this.Controls.Add(this.playListArea);
            this.Controls.Add(this.trackBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel musicArea;
        private MusicTrackBar trackBar1;
        private FlowLayoutPanel playListArea;
    }
}