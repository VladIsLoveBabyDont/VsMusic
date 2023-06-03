namespace VsMusic
{
    partial class CustomButton
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
            this.buttonArea = new System.Windows.Forms.TableLayoutPanel();
            this.button = new System.Windows.Forms.Button();
            this.buttonArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonArea
            // 
            this.buttonArea.ColumnCount = 1;
            this.buttonArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonArea.Controls.Add(this.button, 0, 0);
            this.buttonArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonArea.Location = new System.Drawing.Point(0, 0);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.RowCount = 1;
            this.buttonArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonArea.Size = new System.Drawing.Size(50, 50);
            this.buttonArea.TabIndex = 0;
            // 
            // button
            // 
            this.button.BackgroundImage = global::VsMusic.Properties.Resources.play;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Location = new System.Drawing.Point(7, 7);
            this.button.Margin = new System.Windows.Forms.Padding(7);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(36, 36);
            this.button.TabIndex = 0;
            this.button.UseVisualStyleBackColor = true;
            // 
            // CustomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonArea);
            this.Name = "CustomButton";
            this.Size = new System.Drawing.Size(50, 50);
            this.buttonArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel buttonArea;
        private Button button;
    }
}
