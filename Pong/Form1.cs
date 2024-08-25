using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
  


    public partial class AboutForm : Form
    {
        string username = "Player";
        string computerName = "Computer";
        int ballXspeed = 4;
        int ballYspeed = 4;
        int speed = 2;
        Random rand = new Random();
        bool goDown, goUp;
        bool goDown2, goUp2;
        int jug2_speed_change = 50;
        int jug1score = 0;
        int jug2score = 0;
        int jug1speed = 8;
        int[] i = { 5, 6, 8, 9 };
        int[] j = { 10, 9, 8, 11, 12 };
        bool infiniteMode = false;
        bool multiplayer = false;
        

        public AboutForm()
        {
            InitializeComponent();
            toolStripTextBox1.Text = username;
            toolStripTextBox2.Text = computerName;
            if (toolStripTextBox1.Text != username)
            {
                username = toolStripTextBox1.Text;
            }
            if (toolStripTextBox2.Text != computerName)
            {
                computerName = toolStripTextBox2.Text;
            }
            this.BackColor = Color.DeepSkyBlue;
            bola.BackColor = Color.DeepSkyBlue;
            if (multiplayer)
            {
                
                jug2_speed_change = 0;
                int[] i = { 0 };
                int[] j = { 0 };
            }
        }

        private void GameTimerEvents(object sender, EventArgs e)
        {
            bola.Top -= ballYspeed;
            bola.Left -= ballXspeed;

            this.Text = "Pong!";
            ScoreLabel1.Text = username + "'s score: " + jug1score;
            ScoreLabel2.Text = computerName + "'s score: " + jug2score;
            username = toolStripTextBox1.Text;
            computerName = toolStripTextBox2.Text;

            if (bola.Top < 0 || bola.Bottom > this.ClientSize.Height)
            {
                ballYspeed = -ballYspeed;
            }
            if (bola.Left < -2)
            {
                bola.Left = 300;
                ballXspeed = -ballXspeed;
                jug2score++;
            }
            if (bola.Right > this.ClientSize.Width + 2)
            {
                bola.Left = 300;
                ballXspeed = -ballXspeed;
                jug1score++;
            }
            if (jug2.Top <= 1)
            {
                jug2.Top = 0;
            }
            else if (jug2.Bottom >= this.ClientSize.Height)
            {
                jug2.Top = this.ClientSize.Height - jug2.Height;
            }

            if (bola.Top < jug2.Top + (jug2.Height / 2) && bola.Left > 300)
            {
                jug2.Top -= speed;
            }
            if (bola.Top > jug2.Top + (jug2.Height / 2) && bola.Left > 300)
            {
                jug2.Top += speed;
            }

            jug2_speed_change -= 1;

            if (jug2_speed_change > 0)
            {
                speed = i[rand.Next(i.Length)];
                jug2_speed_change = 50;
            }

            if (goDown && jug1.Top + jug1.Height < this.ClientSize.Height)
            {
                jug1.Top += jug1speed;
            }

            if (goUp && jug1.Top > 0)
            {
                jug1.Top -= jug1speed;
            }

            if (multiplayer == true)
            {                                
                if (goDown2 && jug2.Top + jug1.Height < this.ClientSize.Height)
                {
                    jug2.Top += jug1speed;
                }

                if (goUp2 && jug2.Top > 0)
                {
                    jug2.Top -= jug1speed;
                }

                if (jug2_speed_change > 0)
                {
                    speed = 0;
                    jug2_speed_change = 0;
                }

            }

            CheckCollision(bola, jug1, jug1.Right + 5);
            CheckCollision(bola, jug2, jug2.Left - 35);

            if (jug2score > 5)
            {
                GameOver("Player 2/Computer WINS");
                GameReset("Press OK to Continue");
            }
            else if (jug1score > 5)
            {
                GameOver("Player 1 WINS");
                GameReset("Press OK to Continue");
            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void newF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            
            if (MessageBox.Show("Do you want to reset the actual game?", "New Game...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GameTimer.Stop();
                GameReset("Press OK to Unpause...");
                jug1score = 0;
                jug2score = 0;
                ballXspeed = ballYspeed = 4;
                jug2_speed_change = 50;
                GameTimer.Start();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void difficultyF3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameOver(string message)
        {
            if (infiniteMode == true)
            {
                return;
            }
            else
            {
                GameTimer.Stop();
                MessageBox.Show(message, "Game Over");
                jug1score = 0;
                jug2score = 0;
                ballXspeed = ballYspeed = 4;
                jug2_speed_change = 50;
                GameTimer.Start();
            }
        }

        private void GameReset(string message)
        {
            if (infiniteMode == true)
            {
                return;
            }
            else
            {
                GameTimer.Stop();
                MessageBox.Show(message, "New Game...");
                jug1score = 0;
                jug2score = 0;
                ballXspeed = ballYspeed = 4;
                jug2_speed_change = 50;
                GameTimer.Start();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.PageDown)
            {
                goDown2 = false;
            }
            if (e.KeyCode == Keys.PageUp)
            {
                goUp2 = false;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.PageDown)
            {
                goDown2 = true;
            }
            if (e.KeyCode == Keys.PageUp)
            {
                goUp2 = true;
            }

            //New Game F2
            if (e.KeyCode == Keys.F2)
            {
                GameTimer.Stop();

                if (MessageBox.Show("Do you want to reset the actual game?", "New Game...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GameTimer.Stop();
                    GameReset("Press OK to Unpause...");
                    jug1score = 0;
                    jug2score = 0;
                    ballXspeed = ballYspeed = 4;
                    jug2_speed_change = 50;
                    GameTimer.Start();
                }
            }
            //Exit F4
            if (e.KeyCode == Keys.F4)
            {
                GameTimer.Stop();

                if (MessageBox.Show("Do you want to exit the actual game?", "Exit Game...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    System.Windows.Forms.Application.Exit();

                }
            }
        }

        private void exitF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            
            if (MessageBox.Show("Do you want to exit the actual game?", "Exit Game...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                System.Windows.Forms.Application.Exit();
                
            }
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTimer.Interval = 40;
            GameReset("Slow Speed");
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTimer.Interval = 20;
            GameReset("Normal Speed");
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTimer.Interval = 10;
            GameReset("Fast Mode");
        }

        private void playerVsCPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameReset(username + " vs. " + computerName);
            infiniteMode = false;
            multiplayer = false;

        }

        private void infiniteModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameReset("Infinite Mode: No score limit");
            infiniteMode = true;
            multiplayer = false;
        }

        private void changePlayerUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
        }

        private void PongForm_Load(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            bola.BackColor = Color.White;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            bola.BackColor = Color.Black;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            bola.BackColor = Color.Blue;
        }

        private void aliceBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            bola.BackColor = Color.AliceBlue;
            this.TransparencyKey = Color.DarkSalmon;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            bola.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            bola.BackColor = Color.Green;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            bola.BackColor = Color.Orange;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            bola.BackColor = Color.Purple;
        }

        private void transparentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            bola.BackColor = Color.AliceBlue;
            this.TransparencyKey = Color.AliceBlue;
        }

        private void deepSkyBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepSkyBlue;
            bola.BackColor = Color.DeepSkyBlue;
        }

        private void antiqueWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
            bola.BackColor = Color.AntiqueWhite;
        }

        private void playerInfiniteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameReset("Infinite 2-Player Mode!");
            multiplayer = true;
            infiniteMode = true;
        }

        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {
        
        }

        private void modeF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutF7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            about about = new about();
            about.Show();
            
        }

        private void playerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameReset(username + " vs. " + computerName + " [2-Player Mode]");
            multiplayer = true;
            infiniteMode = false;
        }

        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset)
        {
            if (PicOne.Bounds.IntersectsWith(PicTwo.Bounds))
            {
                PicOne.Left = offset;

                int x = j[rand.Next(j.Length)];
                int y = j[rand.Next(j.Length)];

                if (ballXspeed < 0)
                {
                    ballXspeed = x;
                }
                else
                {
                    ballXspeed = -x;
                }

                if (ballYspeed < 0)
                {
                    ballYspeed = -y;
                }
                else
                {
                    ballYspeed = y;
                }
            }
        }
    }
}
