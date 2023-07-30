using System.Diagnostics;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        private int score = 0; // Score variable to keep track of the score
        private int level = 1;
        public static Stopwatch watch = new Stopwatch();
        private Random random = new Random();
        private bool watchStarted = false; // Track whether the watch has started

        public Form1()
        {
            InitializeComponent();
        }

        private void SetBackground()
        {
            //set background/styling according to level
            switch (level)
            {
                case 1:
                    // Set the background image to waterPng
                    this.BackgroundImage = Properties.Resources.waterPng;
                    this.BackColor = Color.AliceBlue;
                    break;
                case 2:
                    // Set the background image to grassPng
                    this.BackgroundImage = Properties.Resources.grassPng;
                    this.BackColor = Color.Olive;
                    break;
                case 3:
                    // Set the background image to dirtPng
                    this.BackgroundImage = Properties.Resources.dirtPng;
                    this.BackColor = Color.Beige;
                    break;
            }
        }

        private void LevelUp()
        {
            //increase level/speed
            level += 1;
            timer1.Interval -= 100;
            levelLabel.Text = "Level " + level.ToString();
            SetBackground();
        }

        private void GameOver()
        {
            //watch stops, displays message with stats from game
            watch.Stop();
            watchStarted = false;
            //death display
            this.BackgroundImage = Properties.Resources.deathPng;
            this.BackColor = Color.Black;
            //hide all stopwatch buttons
            start.Visible = false;
            stop.Visible = false;
            reset.Visible = false;
            MessageBox.Show("GAME OVER\nScore: " + score + "\nTime: " + time.Text);
            //loser text displays, play again button displays
            endGame.Text = "YOU LOSE!";
            endGame.ForeColor = Color.Red;
            endGame.Visible = true;
            playAgain.Visible = true;
        }

        private void GameWon()
        {
            //watch stops, displays message with stats from game
            watch.Stop();
            watchStarted = false;
            //set winning background
            this.BackgroundImage = Properties.Resources.fireworksPng;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            //hide all stopwatch buttons
            start.Visible = false;
            stop.Visible = false;
            reset.Visible = false;
            MessageBox.Show("CONGRATULATIONS!\nScore: " + score + "\nTime: " + time.Text);
            //winner text displays, play again button displays
            endGame.Text = "YOU WIN!";
            endGame.Visible = true;
            playAgain.Visible = true;
        }

        private void start_Click(object sender, EventArgs e)
        {
            //start watch
            watch.Start();
            watchStarted = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            //stop watch
            watch.Stop();
            watchStarted = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            //reset watch
            watch.Reset();
            watchStarted = false;
            score = 0;
            scoreLabel.Text = "Score: 0";
            level = 0;
            levelLabel.Text = "Level " + level.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //seconds only show in whole seconds
            time.Text = string.Format("{0:00}:{1:00}:{2:00}", watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds);

            if (random.Next(0, 10) < 5)
            {
                target.Left = random.Next(0, this.Width);
                bomb.Left = random.Next(0, this.Width);
                target.Top = random.Next(0, this.Height);
                bomb.Top = random.Next(0, this.Height);
                if (watchStarted)
                {
                    target.Visible = true;
                    bomb.Visible = true;
                }
                else
                {
                    target.Visible = false;
                    bomb.Visible = false;
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //when form is clicked instead of weasel, game ends
            GameOver();
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            //display all stopwatch buttons again
            start.Visible = true;
            stop.Visible = true;
            reset.Visible = true;
            //reset score & time
            watch.Reset();
            score = 0;
            scoreLabel.Text = "Score: 0";
            //hide playAgain button
            playAgain.Visible = false;
            endGame.Visible = false;
            //set background
            SetBackground();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GameOver();
        }

        private void target_Click_1(object sender, EventArgs e)
        {
            target.Visible = false;
            score += 1;
            scoreLabel.Text = "Score: " + score.ToString();

            //if player reaches desired score, player wins
            if (score == 15) GameWon();
            else if (score % 5 == 0) LevelUp();
        }
    }
}