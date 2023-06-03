namespace VsMusic
{
    partial class MusicItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicItem));
            this.itemArea = new System.Windows.Forms.TableLayoutPanel();
            this.description = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.playButton = new VsMusic.CustomButton();
            this.display = new System.Windows.Forms.Timer(this.components);
            this.itemArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // itemArea
            // 
            this.itemArea.ColumnCount = 1;
            this.itemArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.itemArea.Controls.Add(this.description, 0, 2);
            this.itemArea.Controls.Add(this.image, 0, 0);
            this.itemArea.Controls.Add(this.title, 0, 1);
            this.itemArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemArea.Location = new System.Drawing.Point(0, 0);
            this.itemArea.Margin = new System.Windows.Forms.Padding(0);
            this.itemArea.Name = "itemArea";
            this.itemArea.Padding = new System.Windows.Forms.Padding(20);
            this.itemArea.RowCount = 3;
            this.itemArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.itemArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.itemArea.Size = new System.Drawing.Size(231, 330);
            this.itemArea.TabIndex = 0;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.description.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.ForeColor = System.Drawing.Color.Silver;
            this.description.Location = new System.Drawing.Point(23, 270);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(185, 40);
            this.description.TabIndex = 2;
            this.description.Text = "descriptipn";
            this.description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // image
            // 
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.Image = global::VsMusic.Properties.Resources.albom;
            this.image.Location = new System.Drawing.Point(20, 20);
            this.image.Margin = new System.Windows.Forms.Padding(0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(191, 210);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.Location = new System.Drawing.Point(23, 230);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(185, 40);
            this.title.TabIndex = 1;
            this.title.Text = "title";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(80)))));
            this.playButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("playButton.ButtonImage")));
            this.playButton.Location = new System.Drawing.Point(170, 200);
            this.playButton.Name = "playButton";
            this.playButton.Radius = 20;
            this.playButton.Size = new System.Drawing.Size(50, 50);
            this.playButton.TabIndex = 1;
            this.playButton.Visible = false;
            // 
            // display
            // 
            this.display.Enabled = true;
            this.display.Interval = 10;
            this.display.Tick += new System.EventHandler(this.display_Tick);
            // 
            // MusicItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.itemArea);
            this.Name = "MusicItem";
            this.Size = new System.Drawing.Size(231, 330);
            this.itemArea.ResumeLayout(false);
            this.itemArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel itemArea;
        private PictureBox image;
        private Label description;
        private Label title;
        private CustomButton playButton;
        private System.Windows.Forms.Timer display;
    }
}
