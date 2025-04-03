namespace flappycat
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.PictureBox pipe;
        private System.Windows.Forms.PictureBox pipe2;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.character = new System.Windows.Forms.PictureBox();
            this.pipe = new System.Windows.Forms.PictureBox();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();

            // Form ayarları
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "FlappyCat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);

            // character
            this.character.Image = Image.FromFile("images/character.png");
            this.character.Location = new System.Drawing.Point(100, 150);
            this.character.Size = new System.Drawing.Size(50, 50);
            this.character.SizeMode = PictureBoxSizeMode.StretchImage;

            // pipe (üst boru - ters)
            Image topPipe = Image.FromFile("images/Pipe.png");
            topPipe.RotateFlip(RotateFlipType.Rotate180FlipY);
            this.pipe.Image = topPipe;
            this.pipe.Location = new System.Drawing.Point(400, -120);
            this.pipe.Size = new System.Drawing.Size(100, 250);
            this.pipe.SizeMode = PictureBoxSizeMode.StretchImage;

            // pipe2 (alt boru)
            this.pipe2.Image = Image.FromFile("images/Pipe.png");
            this.pipe2.Location = new System.Drawing.Point(400, 250);
            this.pipe2.Size = new System.Drawing.Size(100, 250);
            this.pipe2.SizeMode = PictureBoxSizeMode.StretchImage;

            // ground
            this.ground.Image = Image.FromFile("images/Zemin.png");
            this.ground.Location = new System.Drawing.Point(0, 400);
            this.ground.Size = new System.Drawing.Size(800, 50);
            this.ground.SizeMode = PictureBoxSizeMode.StretchImage;

            // scoreLabel
            this.scoreLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Location = new System.Drawing.Point(10, 10);
            this.scoreLabel.Size = new System.Drawing.Size(300, 30);
            this.scoreLabel.Text = "Score: 0";

            // gameTimer
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);

            // btnStart
            this.btnStart.Text = "Start";
            this.btnStart.Location = new System.Drawing.Point(650, 10);
            this.btnStart.Size = new System.Drawing.Size(60, 30);
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // btnRestart
            this.btnRestart.Text = "Restart";
            this.btnRestart.Location = new System.Drawing.Point(720, 10);
            this.btnRestart.Size = new System.Drawing.Size(60, 30);
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);

            // Controls
            this.Controls.Add(this.character);
            this.Controls.Add(this.pipe);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRestart);

            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
        }
    }
}
