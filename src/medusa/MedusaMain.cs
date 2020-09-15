using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace medusa
{
    public partial class MedusaMain : Form
    {
        private Bitmap Canvas { get; set; }
        private int MarkPosX { get; set; }
        private int MarkPosY { get; set; }
        private int MarkWidth { get; } = 50;
        private int MarkHeight { get; } = 50;
        private bool IsStop { get; set; } = false;

        private readonly object _locked = new object();
        private FormWindowState _currentWindowState;

        public MedusaMain()
        {
            InitializeComponent();
            _currentWindowState = WindowState;
            Canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            DrawBackGround();
            StopTrainingMenu.Enabled = false;
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
                    lock (_locked)
                    {
                        DrawBackGround();
                    }

                    lock (_locked)
                    {
                        DecideMarkPos();
                        DrawMark();
                    }

                    lock (_locked)
                    {
                        Thread.Sleep(500);
                    }

                    if (IsStop)
                    {
                        break;
                    }
                }
            });
        }

        private void DrawBackGround()
        {
            using (Graphics g = Graphics.FromImage(Canvas))
            {
                g.FillRectangle(Brushes.Black, 0, 0, pictureBox.Width, pictureBox.Height);
            }
            pictureBox.Image = Canvas;
        }

        private void DecideMarkPos()
        {
            Random r = new Random();
            MarkPosX = r.Next(0, Canvas.Width - MarkWidth);
            MarkPosY = r.Next(0, Canvas.Height - MarkHeight);
        }

        private void DrawMark()
        {            
            using (Graphics g = Graphics.FromImage(Canvas))
            {
                g.FillEllipse(Brushes.Yellow, MarkPosX, MarkPosY, MarkWidth, MarkHeight);
            }
            pictureBox.Image = Canvas;
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
            lock (_locked)
            {
                Canvas.Dispose();
                Canvas = new Bitmap(pictureBox.Width, pictureBox.Height);

                //In case of no training, only background will be drown.
                if (StartTrainingMenu.Enabled)
                {
                    DrawBackGround();
                }
            }
        }
    }
}
