using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VsMusic
{
    public partial class CustomTrackBar : UserControl
    {
        public CustomTrackBar()
        {
            InitializeComponent();
            RecursiveHendlerHover(areaVolumeControl);

            volumeControl.MouseWheel += VolumeControl_MouseWheel;
            Value = 50;
        }

        public event EventHandler ChangeVolume;

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
            whiteLine.BackColor = Color.FromArgb(0, 160, 140);
        }
        private void Element_MouseLeave(object? sender, EventArgs e)
        {
            whiteLine.BackColor = Color.FromArgb(255, 255, 255);
        }
        #endregion


        public float Value { get; set; } 
        float currentValue = 50;
        private void volumeControl_MouseClick(object sender, MouseEventArgs e)
        {
            float percent = (float)e.X / volumeControl.Width * 100.0f;
            currentValue = percent;
            UpdateVolumeControl();
        }
        private void grayLine_MouseClick(object sender, MouseEventArgs e)
        {
            float percent = ((float)e.X + whiteLine.Width) / volumeControl.Width * 100.0f;
            currentValue = percent;
            UpdateVolumeControl();
        }

        private void VolumeControl_MouseWheel(object? sender, MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                if(currentValue < 100)
                    currentValue += 5;
            }
            else
            {
                if (currentValue > 0)
                    currentValue -= 5;
            }
            UpdateVolumeControl();
        }

        void UpdateVolumeControl()
        {
            float value = currentValue;
            if (value <= 0 || mute)
            {
                value = 0;
            }
            else if (value >= 100)
            {
                value = 100;
            }

            Value = value;
            ChangeVolume.Invoke(this, EventArgs.Empty);
            volumeControl.ColumnStyles[0].Width = value;
            volumeControl.ColumnStyles[1].Width = 100 - value;
        }

        bool mute = false;
        private void picVolume_Click(object sender, EventArgs e)
        {
            mute = !mute;
            if (mute)
            {
                picVolume.Image = Properties.Resources.volumeMute;
            }
            else
            {
                picVolume.Image = Properties.Resources.volume;
            }

            UpdateVolumeControl();
        }
    }
}
