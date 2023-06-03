namespace VsMusic
{
    partial class CustomTrackBar
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
            this.areaVolumeControl = new System.Windows.Forms.TableLayoutPanel();
            this.picVolume = new System.Windows.Forms.PictureBox();
            this.volumeControl = new System.Windows.Forms.TableLayoutPanel();
            this.grayLine = new System.Windows.Forms.Label();
            this.whiteLine = new System.Windows.Forms.Label();
            this.areaVolumeControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).BeginInit();
            this.volumeControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // areaVolumeControl
            // 
            this.areaVolumeControl.ColumnCount = 2;
            this.areaVolumeControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.areaVolumeControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.areaVolumeControl.Controls.Add(this.picVolume, 0, 0);
            this.areaVolumeControl.Controls.Add(this.volumeControl, 1, 0);
            this.areaVolumeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areaVolumeControl.Location = new System.Drawing.Point(0, 0);
            this.areaVolumeControl.Margin = new System.Windows.Forms.Padding(0);
            this.areaVolumeControl.Name = "areaVolumeControl";
            this.areaVolumeControl.Padding = new System.Windows.Forms.Padding(8);
            this.areaVolumeControl.RowCount = 1;
            this.areaVolumeControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.areaVolumeControl.Size = new System.Drawing.Size(200, 60);
            this.areaVolumeControl.TabIndex = 0;
            // 
            // picVolume
            // 
            this.picVolume.Image = global::VsMusic.Properties.Resources.volume;
            this.picVolume.Location = new System.Drawing.Point(15, 15);
            this.picVolume.Margin = new System.Windows.Forms.Padding(7);
            this.picVolume.Name = "picVolume";
            this.picVolume.Size = new System.Drawing.Size(26, 30);
            this.picVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVolume.TabIndex = 0;
            this.picVolume.TabStop = false;
            this.picVolume.Click += new System.EventHandler(this.picVolume_Click);
            // 
            // volumeControl
            // 
            this.volumeControl.ColumnCount = 2;
            this.volumeControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.volumeControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.volumeControl.Controls.Add(this.grayLine, 0, 0);
            this.volumeControl.Controls.Add(this.whiteLine, 0, 0);
            this.volumeControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeControl.Location = new System.Drawing.Point(51, 11);
            this.volumeControl.Name = "volumeControl";
            this.volumeControl.Padding = new System.Windows.Forms.Padding(0, 14, 0, 14);
            this.volumeControl.RowCount = 1;
            this.volumeControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.volumeControl.Size = new System.Drawing.Size(134, 34);
            this.volumeControl.TabIndex = 1;
            this.volumeControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.volumeControl_MouseClick);
            // 
            // grayLine
            // 
            this.grayLine.AutoSize = true;
            this.grayLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grayLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grayLine.Location = new System.Drawing.Point(67, 14);
            this.grayLine.Margin = new System.Windows.Forms.Padding(0);
            this.grayLine.Name = "grayLine";
            this.grayLine.Size = new System.Drawing.Size(67, 6);
            this.grayLine.TabIndex = 1;
            this.grayLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grayLine_MouseClick);
            // 
            // whiteLine
            // 
            this.whiteLine.AutoSize = true;
            this.whiteLine.BackColor = System.Drawing.Color.White;
            this.whiteLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whiteLine.Location = new System.Drawing.Point(0, 14);
            this.whiteLine.Margin = new System.Windows.Forms.Padding(0);
            this.whiteLine.Name = "whiteLine";
            this.whiteLine.Size = new System.Drawing.Size(67, 6);
            this.whiteLine.TabIndex = 0;
            this.whiteLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.volumeControl_MouseClick);
            // 
            // CustomTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.areaVolumeControl);
            this.Name = "CustomTrackBar";
            this.Size = new System.Drawing.Size(200, 60);
            this.areaVolumeControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).EndInit();
            this.volumeControl.ResumeLayout(false);
            this.volumeControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel areaVolumeControl;
        private PictureBox picVolume;
        private TableLayoutPanel volumeControl;
        private Label whiteLine;
        private Label grayLine;
    }
}
