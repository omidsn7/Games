using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrexGame
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumsSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Trex.Top += jumsSpeed;
            lbl_score.Text = "Score : " + score;

            if (jumping == true && force <0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumsSpeed = -12;
                force -= 1;
            }
            else
            {
                jumsSpeed = 12;
            }
            if (Trex.Top > 233 && jumping == false)
            {
                force = 12;
                Trex.Top = 233;
                jumsSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacles")
                {
                    x.Left -= obstacleSpeed;

                    if(x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }
                    if (Trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        Trex.Image = Properties.Resources.dead;
                        lbl_score.Text += "\n" + "Press R to restart the game!!!!";
                        isGameOver = true;
                    }
                }
            }
            
            if(score > 5)
            {
                obstacleSpeed = 15;
            }
            if(score > 10)
            {
                obstacleSpeed = 20;
            }
            if(score > 15)
            {
                obstacleSpeed = 25;
            }


        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }
        
        private void GameReset()
        {
            force = 12;
            jumsSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            lbl_score.Text = "Score : " + score;
            Trex.Image = Properties.Resources.running;
            isGameOver = false;
            Trex.Top = 233;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacles")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }
            GameTimer.Start();
        }
    }
}
