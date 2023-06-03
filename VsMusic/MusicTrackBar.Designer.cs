namespace VsMusic
{
    partial class MusicTrackBar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicTrackBar));
            this.TrackBarArea = new System.Windows.Forms.TableLayoutPanel();
            this.progres = new System.Windows.Forms.TableLayoutPanel();
            this.whiteLine = new System.Windows.Forms.Label();
            this.controlArea = new System.Windows.Forms.TableLayoutPanel();
            this.controlSector = new System.Windows.Forms.TableLayoutPanel();
            this.previos = new VsMusic.CustomButton();
            this.next = new VsMusic.CustomButton();
            this.playPause = new VsMusic.CustomButton();
            this.volumeControl = new VsMusic.CustomTrackBar();
            this.audioTime = new System.Windows.Forms.Timer(this.components);
            this.TrackBarArea.SuspendLayout();
            this.progres.SuspendLayout();
            this.controlArea.SuspendLayout();
            this.controlSector.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrackBarArea
            // 
            this.TrackBarArea.ColumnCount = 1;
            this.TrackBarArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TrackBarArea.Controls.Add(this.progres, 0, 0);
            this.TrackBarArea.Controls.Add(this.controlArea, 0, 1);
            this.TrackBarArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarArea.Location = new System.Drawing.Point(0, 0);
            this.TrackBarArea.Name = "TrackBarArea";
            this.TrackBarArea.RowCount = 2;
            this.TrackBarArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TrackBarArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TrackBarArea.Size = new System.Drawing.Size(634, 70);
            this.TrackBarArea.TabIndex = 0;
            // 
            // progres
            // 
            this.progres.ColumnCount = 2;
            this.progres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.progres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.progres.Controls.Add(this.whiteLine, 0, 0);
            this.progres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progres.Location = new System.Drawing.Point(0, 0);
            this.progres.Margin = new System.Windows.Forms.Padding(0);
            this.progres.Name = "progres";
            this.progres.RowCount = 1;
            this.progres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.progres.Size = new System.Drawing.Size(634, 10);
            this.progres.TabIndex = 0;
            this.progres.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progres_MouseClick);
            // 
            // whiteLine
            // 
            this.whiteLine.AutoSize = true;
            this.whiteLine.BackColor = System.Drawing.Color.White;
            this.whiteLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whiteLine.Location = new System.Drawing.Point(0, 0);
            this.whiteLine.Margin = new System.Windows.Forms.Padding(0);
            this.whiteLine.Name = "whiteLine";
            this.whiteLine.Size = new System.Drawing.Size(1, 10);
            this.whiteLine.TabIndex = 0;
            this.whiteLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progres_MouseClick);
            // 
            // controlArea
            // 
            this.controlArea.ColumnCount = 3;
            this.controlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.controlArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlArea.Controls.Add(this.controlSector, 1, 0);
            this.controlArea.Controls.Add(this.volumeControl, 2, 0);
            this.controlArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlArea.Location = new System.Drawing.Point(0, 10);
            this.controlArea.Margin = new System.Windows.Forms.Padding(0);
            this.controlArea.Name = "controlArea";
            this.controlArea.RowCount = 1;
            this.controlArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlArea.Size = new System.Drawing.Size(634, 60);
            this.controlArea.TabIndex = 1;
            // 
            // controlSector
            // 
            this.controlSector.ColumnCount = 5;
            this.controlSector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.controlSector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.controlSector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.controlSector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.controlSector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.controlSector.Controls.Add(this.previos, 1, 0);
            this.controlSector.Controls.Add(this.next, 3, 0);
            this.controlSector.Controls.Add(this.playPause, 2, 0);
            this.controlSector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlSector.Location = new System.Drawing.Point(167, 0);
            this.controlSector.Margin = new System.Windows.Forms.Padding(0);
            this.controlSector.Name = "controlSector";
            this.controlSector.RowCount = 1;
            this.controlSector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlSector.Size = new System.Drawing.Size(300, 60);
            this.controlSector.TabIndex = 0;
            // 
            // previos
            // 
            this.previos.ButtonImage = global::VsMusic.Properties.Resources.previos;
            this.previos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previos.Location = new System.Drawing.Point(63, 3);
            this.previos.Name = "previos";
            this.previos.Radius = 20;
            this.previos.Size = new System.Drawing.Size(54, 54);
            this.previos.TabIndex = 2;
            this.previos.CustomClick += new System.EventHandler(this.previos_CustomClick);
            // 
            // next
            // 
            this.next.ButtonImage = global::VsMusic.Properties.Resources.next;
            this.next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.next.Location = new System.Drawing.Point(183, 3);
            this.next.Name = "next";
            this.next.Radius = 20;
            this.next.Size = new System.Drawing.Size(54, 54);
            this.next.TabIndex = 1;
            this.next.CustomClick += new System.EventHandler(this.next_CustomClick);
            // 
            // playPause
            // 
            this.playPause.ButtonImage = ((System.Drawing.Image)(resources.GetObject("playPause.ButtonImage")));
            this.playPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playPause.Location = new System.Drawing.Point(123, 3);
            this.playPause.Name = "playPause";
            this.playPause.Radius = 20;
            this.playPause.Size = new System.Drawing.Size(54, 54);
            this.playPause.TabIndex = 0;
            // 
            // volumeControl
            // 
            this.volumeControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.volumeControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.volumeControl.Location = new System.Drawing.Point(470, 3);
            this.volumeControl.Name = "volumeControl";
            this.volumeControl.Size = new System.Drawing.Size(161, 54);
            this.volumeControl.TabIndex = 3;
            // 
            // audioTime
            // 
            this.audioTime.Interval = 1000;
            this.audioTime.Tick += new System.EventHandler(this.audioTime_Tick);
            // 
            // MusicTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.TrackBarArea);
            this.Name = "MusicTrackBar";
            this.Size = new System.Drawing.Size(634, 70);
            this.TrackBarArea.ResumeLayout(false);
            this.progres.ResumeLayout(false);
            this.progres.PerformLayout();
            this.controlArea.ResumeLayout(false);
            this.controlSector.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TrackBarArea;
        private TableLayoutPanel progres;
        private Label whiteLine;
        private System.Windows.Forms.Timer audioTime;
        private TableLayoutPanel controlArea;
        private TableLayoutPanel controlSector;
        private CustomButton playPause;
        private CustomButton previos;
        private CustomButton next;
        private CustomTrackBar volumeControl;
    }
}
