using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BallProject__10._07___WinForm____UIThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Random r = new Random();
        List<PictureBox> balls = new List<PictureBox>();
        int index = 0;
        List<int> dx = new List<int>();
        List<int> dy = new List<int>();

        private void AddBallBtn_Click(object sender, EventArgs e)
        {
            CreateBallBtn.Enabled = false;
            RemoveBallsBtn.Enabled = false;
            balls.Add(new PictureBox
            {
                Name = "Ball_" + index.ToString(),
                Image = (Image)Properties.Resources.BallImg,
                Size = new Size(100,100),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(r.Next(50, ClientSize.Width - 50), r.Next(100, ClientSize.Height - 100)),
            });
            dx.Add(1);
            dy.Add(1);
            this.Controls.Add(balls[index++]);

            Task.Run(() => 
            {
                MoveBall();
            });

            Task.Run(() => 
            {
                EnableButtons();
            });

        }

        private void MoveBall()
        {
            int numberBall = index-1;
            while (balls[numberBall].Name != "Removed")
            {
                    Action a = () => { balls[numberBall].Location = new Point(balls[numberBall].Location.X + dx[numberBall], balls[numberBall].Location.Y + dy[numberBall]); };
                    this.BeginInvoke(a);

                    if (balls[numberBall].Location.X + dx[numberBall] <= 0)
                        dx[numberBall] = 1;
                    if (balls[numberBall].Location.X + dx[numberBall] >= ClientSize.Width - balls[numberBall].Width)
                        dx[numberBall] = -1;
                    if (balls[numberBall].Location.Y + dy[numberBall] <= 0 + CreateBallBtn.Height)
                        dy[numberBall] = 1;
                    if (balls[numberBall].Location.Y + dy[numberBall] >= ClientSize.Height - balls[numberBall].Height)
                        dy[numberBall] = -1;
                    Thread.Sleep(10);
            }
            balls.RemoveAll(a => a.Name == "Removed");
            dx.RemoveAt(dx.Count - 1);
            dy.RemoveAt(dy.Count - 1);
            index--;
        }

        private void RemoveBallsImg_Click(object sender, EventArgs e)
        {
            int numberOfBalls = balls.Count();
            balls[numberOfBalls-1].Name = "Removed";
            this.Controls.Remove(balls[numberOfBalls-1]);
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Location = new Point(ClientSize.Width + Size.Width, ClientSize.Height + Size.Height);
        }

        private void EnableButtons()
        {
            Thread.Sleep(500);
            Action a = () => { CreateBallBtn.Enabled = true; RemoveBallsBtn.Enabled = true; };
            this.BeginInvoke(a);
        }
    }
}