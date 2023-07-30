namespace StopWatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            time = new Label();
            start = new Button();
            stop = new Button();
            reset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            scoreLabel = new Label();
            playAgain = new Button();
            endGame = new Label();
            levelLabel = new Label();
            bomb = new PictureBox();
            target = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bomb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)target).BeginInit();
            SuspendLayout();
            // 
            // time
            // 
            time.AutoSize = true;
            time.Location = new Point(12, 9);
            time.Name = "time";
            time.Size = new Size(78, 32);
            time.TabIndex = 0;
            time.Text = "label1";
            // 
            // start
            // 
            start.Location = new Point(12, 392);
            start.Name = "start";
            start.Size = new Size(150, 46);
            start.TabIndex = 1;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // stop
            // 
            stop.Location = new Point(168, 392);
            stop.Name = "stop";
            stop.Size = new Size(150, 46);
            stop.TabIndex = 2;
            stop.Text = "Stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // reset
            // 
            reset.Location = new Point(324, 392);
            reset.Name = "reset";
            reset.Size = new Size(150, 46);
            reset.TabIndex = 3;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(349, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(98, 32);
            scoreLabel.TabIndex = 5;
            scoreLabel.Text = "Score: 0";
            // 
            // playAgain
            // 
            playAgain.Location = new Point(236, 134);
            playAgain.Name = "playAgain";
            playAgain.Size = new Size(331, 121);
            playAgain.TabIndex = 0;
            playAgain.Text = "Play Again";
            playAgain.UseVisualStyleBackColor = true;
            playAgain.Visible = false;
            playAgain.Click += playAgain_Click;
            // 
            // endGame
            // 
            endGame.AutoSize = true;
            endGame.Location = new Point(369, 99);
            endGame.Name = "endGame";
            endGame.Size = new Size(78, 32);
            endGame.TabIndex = 6;
            endGame.Text = "label1";
            endGame.Visible = false;
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new Point(698, 9);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(89, 32);
            levelLabel.TabIndex = 7;
            levelLabel.Text = "Level 1";
            // 
            // bomb
            // 
            bomb.BackColor = Color.Transparent;
            bomb.Image = (Image)resources.GetObject("bomb.Image");
            bomb.Location = new Point(602, 348);
            bomb.Name = "bomb";
            bomb.Size = new Size(200, 100);
            bomb.SizeMode = PictureBoxSizeMode.Zoom;
            bomb.TabIndex = 8;
            bomb.TabStop = false;
            bomb.Click += pictureBox1_Click;
            // 
            // target
            // 
            target.BackColor = Color.Transparent;
            target.Image = (Image)resources.GetObject("target.Image");
            target.Location = new Point(30, 101);
            target.Name = "target";
            target.Size = new Size(200, 100);
            target.SizeMode = PictureBoxSizeMode.Zoom;
            target.TabIndex = 9;
            target.TabStop = false;
            target.Click += target_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(target);
            Controls.Add(bomb);
            Controls.Add(levelLabel);
            Controls.Add(endGame);
            Controls.Add(playAgain);
            Controls.Add(scoreLabel);
            Controls.Add(reset);
            Controls.Add(stop);
            Controls.Add(start);
            Controls.Add(time);
            Name = "Form1";
            Text = "POP GOES THE WEASEL!";
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)bomb).EndInit();
            ((System.ComponentModel.ISupportInitialize)target).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label time;
        private Button start;
        private Button stop;
        private Button reset;
        private System.Windows.Forms.Timer timer1;
        private Label scoreLabel;
        private Button playAgain;
        private Label endGame;
        private Label levelLabel;
        private PictureBox bomb;
        private PictureBox target;
    }
}