using System;
using System.Drawing;
using System.Windows.Forms;

namespace flappycat
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 5;
        int gravity = 5;
        int jumpStrength = 40;
        int score = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            character.Top += gravity;

            pipe.Left -= pipeSpeed;
            pipe2.Left -= pipeSpeed;

            scoreLabel.Text = "Score: " + score;

            if (pipe.Left < -pipe.Width)
            {
                pipe.Left = 800;
                pipe.Top = rand.Next(-200, -50); // Rastgele yükseklik
                score++;
            }

            if (pipe2.Left < -pipe2.Width)
            {
                pipe2.Left = 800;
                score++;
            }

            if (character.Bounds.IntersectsWith(pipe.Bounds) ||
                character.Bounds.IntersectsWith(pipe2.Bounds) ||
                character.Bounds.IntersectsWith(ground.Bounds) ||
                character.Top < 0)
            {
                endGame();
            }

            if (score > 10)
            {
                pipeSpeed = 7;
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (gameTimer.Enabled)
                character.Top -= jumpStrength;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void resetGame()
        {
            score = 0;
            pipeSpeed = 5;
            scoreLabel.Text = "Score: 0";
            character.Location = new Point(100, 150);
            pipe.Location = new Point(400, -120); // üst boru
            pipe2.Location = new Point(400, 250); // alt boru
            gameTimer.Start();
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreLabel.Text = "Game Over! Score: " + score;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
