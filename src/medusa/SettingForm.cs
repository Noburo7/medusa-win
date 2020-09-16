using System;
using System.Drawing;
using System.Windows.Forms;

namespace medusa
{
    public partial class SettingForm : Form
    {
        private Bitmap BackgroundColorCanvas { get; set; }
        private Bitmap MarkerColorCanvas { get; set; }

        public SettingForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            BackgroundColorCanvas = new Bitmap(BackgroundColorPictureBox.Width, BackgroundColorPictureBox.Height);
            MarkerColorCanvas = new Bitmap(MarkerColorPictureBox.Width, MarkerColorPictureBox.Height);
            LoadBackgroundColor();
            LoadMarkerColor();
            LoadMarkerSize();
            LoadMarkerSpeed();
        }

        private void BackgroundColorScrolled(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundColorR = BackgroundColorRTrackBar.Value;
            Properties.Settings.Default.BackgroundColorG = BackgroundColorGTrackBar.Value;
            Properties.Settings.Default.BackgroundColorB = BackgroundColorBTrackBar.Value;
            DrawBackgroundColorCanvas();
        }

        private void DrawBackgroundColorCanvas()
        {
            using (Graphics g = Graphics.FromImage(BackgroundColorCanvas))
            {
                using (var brush = new SolidBrush(Color.FromArgb(Properties.Settings.Default.BackgroundColorR,
                    Properties.Settings.Default.BackgroundColorG, Properties.Settings.Default.BackgroundColorB)))
                {
                    g.FillRectangle(brush, 0, 0, BackgroundColorPictureBox.Width, BackgroundColorPictureBox.Height);
                }            
            }
            BackgroundColorPictureBox.Image = BackgroundColorCanvas;
        }

        private void MarkerColorScrolled(object sender, EventArgs e)
        {
            Properties.Settings.Default.MarkerColorR = MarkerColorRTrackBar.Value;
            Properties.Settings.Default.MarkerColorG = MarkerColorGTrackBar.Value;
            Properties.Settings.Default.MarkerColorB = MarkerColorBTrackBar.Value;
            DrawMarkerColorCanvas();
        }

        private void DrawMarkerColorCanvas()
        {
            using (Graphics g = Graphics.FromImage(MarkerColorCanvas))
            {
                using (var brush = new SolidBrush(Color.FromArgb(Properties.Settings.Default.MarkerColorR,
                    Properties.Settings.Default.MarkerColorG, Properties.Settings.Default.MarkerColorB)))
                {
                    g.FillRectangle(brush, 0, 0, MarkerColorPictureBox.Width, MarkerColorPictureBox.Height);
                }
            }
            MarkerColorPictureBox.Image = MarkerColorCanvas;
        }

        private void LoadBackgroundColor()
        {
            BackgroundColorRTrackBar.Value = Properties.Settings.Default.BackgroundColorR;
            BackgroundColorGTrackBar.Value = Properties.Settings.Default.BackgroundColorG;
            BackgroundColorBTrackBar.Value = Properties.Settings.Default.BackgroundColorB;
            DrawBackgroundColorCanvas();
        }

        private void LoadMarkerColor()
        {
            MarkerColorRTrackBar.Value = Properties.Settings.Default.MarkerColorR;
            MarkerColorGTrackBar.Value = Properties.Settings.Default.MarkerColorG;
            MarkerColorBTrackBar.Value = Properties.Settings.Default.MarkerColorB;
            DrawMarkerColorCanvas();
        }

        private void LoadMarkerSize()
        {
            switch (Properties.Settings.Default.MarkerSize)
            {
                case 0:
                    MarkerSizeSmallRadioButton.Checked = true;
                    break;
                case 1:
                    MarkerSizeMiddleRadioButton.Checked = true;
                    break;
                case 2:
                    MarkerSizeLargeRadioButton.Checked = true;
                    break;
            }
        }

        private void LoadMarkerSpeed()
        {
            switch (Properties.Settings.Default.MarkerSpeed)
            {
                case 0:
                    MarkerSpeedLowRadioButton.Checked = true;
                    break;
                case 1:
                    MarkerSpeedMiddleRadioButton.Checked = true;
                    break;
                case 2:
                    MarkerSpeedHighRadioButton.Checked = true;
                    break;
            }
        }

        private void MarkerSizeCheckedChanged(object sender, EventArgs e)
        {
            if (MarkerSizeSmallRadioButton.Checked)
            {
                Properties.Settings.Default.MarkerSize = 0;
            }
            else if (MarkerSizeMiddleRadioButton.Checked)
            {
                Properties.Settings.Default.MarkerSize = 1;
            }
            else if (MarkerSizeLargeRadioButton.Checked)
            {
                Properties.Settings.Default.MarkerSize = 2;
            }
        }

        private void MarkerSpeedCheckChanged(object sender, EventArgs e)
        {
            if (MarkerSpeedLowRadioButton.Checked)
            {
                Properties.Settings.Default.MarkerSpeed = 0;
            }
            else if (MarkerSpeedMiddleRadioButton.Checked)
            {
                Properties.Settings.Default.MarkerSpeed = 1;
            }
            else if (MarkerSpeedHighRadioButton.Checked)
            {
                Properties.Settings.Default.MarkerSpeed = 2;
            }
        }

        private void SettingFormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
