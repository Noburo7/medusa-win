using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace medusa
{
    public partial class MedusaMain : Form
    {
        private int MarkPosX { get; set; }
        private int MarkPosY { get; set; }
        private bool IsStop { get; set; } = false;

        private FormWindowState _currentWindowState;
        private static object _locker = new object();

        public MedusaMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _currentWindowState = WindowState;
            StopTrainingMenu.Enabled = false;

            var canvas = new Bitmap(TrainingPictureBox.Width, TrainingPictureBox.Height);
            using (var g = Graphics.FromImage(canvas))
            {
                DrawBackGround(g);
            }
            TrainingPictureBox.Image = canvas;
        }
       
        private void StartTrainingMenu_Click(object sender, EventArgs e)
        {
            StartTrainingMenu.Enabled = false;
            StopTrainingMenu.Enabled = true;
            IsStop = false;
            DoTraining();
        }

        private void StopTrainingMenu_Click(object sender, EventArgs e)
        {
            IsStop = true;
            StartTrainingMenu.Enabled = true;
            StopTrainingMenu.Enabled = false;
        }

        private void ExitAppMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoTraining()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    lock (_locker)
                    {
                        var canvas = new Bitmap(TrainingPictureBox.Width, TrainingPictureBox.Height);
                        using (var g = Graphics.FromImage(canvas))
                        {
                            DrawBackGround(g);
                            DecideMarkPos();
                            DrawMark(g);
                        }

                        TrainingPictureBox.Image.Dispose();
                        TrainingPictureBox.Image = canvas;
                    }

                    Thread.Sleep(GetMarkerSpeedByMilliSecond());

                    if (IsStop)
                    {
                        break;
                    }
                }
            });
        }

        private void DrawBackGround(Graphics g)
        {
            using (var brush = new SolidBrush(Color.FromArgb(Properties.Settings.Default.BackgroundColorR,
                Properties.Settings.Default.BackgroundColorG, Properties.Settings.Default.BackgroundColorB)))
            {
                g.FillRectangle(brush, 0, 0, TrainingPictureBox.Width, TrainingPictureBox.Height);
            }
        }

        private void DecideMarkPos()
        {
            var markerSize = GetMarkerSize();
            Random r = new Random();
            MarkPosX = r.Next(0, TrainingPictureBox.Width- markerSize);
            MarkPosY = r.Next(0, TrainingPictureBox.Height - markerSize);
        }

        private void DrawMark(Graphics g)
        {
            var markerSize = GetMarkerSize();
            using (var brush = new SolidBrush(Color.FromArgb(Properties.Settings.Default.MarkerColorR,
                Properties.Settings.Default.MarkerColorG, Properties.Settings.Default.MarkerColorB)))
            {
                g.FillEllipse(brush, MarkPosX, MarkPosY, markerSize, markerSize);
            }
        }

        private void FormResized(object sender, EventArgs e)
        {
            //Re-draw Canvas only when WindowsState(Normal/Maximized/Minimized) was changed
            //in order to avoid heavy processing due to many FormResized() callings.
            //For transition Normal to Normal, Re-draw processing will be done in FormResizeEnd().
            if (WindowState == _currentWindowState) return;
             _currentWindowState = WindowState;

            if (_currentWindowState == FormWindowState.Minimized) return;
            FormResizeEnd(sender, e);
        }

        private void FormResizeEnd(object sender, EventArgs e)
        {
            //In case of no training, only background will be drown.
            if (StartTrainingMenu.Enabled)
            {
                lock (_locker)
                {
                    var canvas = new Bitmap(TrainingPictureBox.Width, TrainingPictureBox.Height);
                    using (var g = Graphics.FromImage(canvas))
                    {
                        DrawBackGround(g);
                    }

                    TrainingPictureBox.Image.Dispose();
                    TrainingPictureBox.Image = canvas;
                }
            }
        }

        private void TrainingSettingMenu_Click(object sender, EventArgs e)
        {
            new SettingForm().Show();
        }

        private int GetMarkerSize()
        {
            return (Properties.Settings.Default.MarkerSize + 1) * 50;
        }

        private int GetMarkerSpeedByMilliSecond()
        {
            if (Properties.Settings.Default.MarkerSpeed == 0)
            {
                return 1000;
            }
            else if (Properties.Settings.Default.MarkerSpeed == 1)
            {
                return 500;
            }
            else
            {
                return 300;
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            //No Meaning! but show splash form.
            var splash = new SplashForm();
            splash.Show();
            Thread.Sleep(2000);
            splash.Close();
        }
    }
}
