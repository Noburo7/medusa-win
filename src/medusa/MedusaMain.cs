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
        private bool isStop = false;

        public MedusaMain()
        {
            InitializeComponent();
            Canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            DrawBackGround();
            StopTrainingMenu.Enabled = false;
        }
       
        private void StartTrainingMenu_Click(object sender, EventArgs e)
        {
            StartTrainingMenu.Enabled = false;
            StopTrainingMenu.Enabled = true;

            Task.Run(() =>
            {
                while (true)
                {
                    DrawBackGround();
                    Thread.Sleep(50);
                    DrawMark();
                    Thread.Sleep(500);

                    if (isStop)
                    {
                        isStop = false;
                        break;
                    }
                }
            });
        }

        private void StopTrainingMenu_Click(object sender, EventArgs e)
        {
            isStop = true;
            StartTrainingMenu.Enabled = true;
            StopTrainingMenu.Enabled = false;
        }

        private void ExitAppMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DrawBackGround()
        {
            using (Graphics g = Graphics.FromImage(Canvas))
            {
                g.FillRectangle(Brushes.Black, 0, 0, pictureBox.Width, pictureBox.Height);
            }
            pictureBox.Image = Canvas;
        }

        private void DrawMark()
        {
            var markWidth = 50;
            var markHeight = 50;
            Random r = new Random();
            var markPosX = r.Next(0, Canvas.Width - markWidth);
            var markPosY = r.Next(0, Canvas.Height - markHeight);
            
            using (Graphics g = Graphics.FromImage(Canvas))
            {
                g.FillEllipse(Brushes.Yellow, markPosX, markPosY, markWidth, markHeight);
            }
            pictureBox.Image = Canvas;
        }
    }
}
