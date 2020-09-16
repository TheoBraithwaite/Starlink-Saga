using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starlink
{
    public partial class frmStarlink : Form
    {
        Graphics g; //declare a graphics object called g
        Satellite[] sat1 = new Satellite[7];
        SatLeft[] sat2 = new SatLeft[7];
        SatRight[] sat3 = new SatRight[7];
        Player pImage = new Player();
        Random yspeed = new Random();
        Random xspeed1 = new Random();
        Random xspeed2 = new Random();
        //declare a list  missiles from the Missile class
        List<Laser> lasers = new List<Laser>();
        bool left, right;
        string move;
        int score, health;

        public frmStarlink()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
                sat1[i] = new Satellite(x);
            }
            for (int l = 0; l < 7; l++)
            {
                int y = 10 + (l * 75);
                sat2[l] = new SatLeft(y);
            }
            for (int r = 0; r < 7; r++)
            {
                int y = 10 + (r * 75);
                sat3[r] = new SatRight(y);
            }
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlStarlink, new object[] { true });
        }

        private void PnlStarlink_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //Call the Player class's DrawPlayer method to draw the spacecraft image, craft1
            pImage.DrawPlayer(g);
            //call the Satellite class's DrawSatellite method to draw the image sat1 
            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 20);
                sat1[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                sat1[i].DrawSatellite(g);
            }
            for (int l = 0; l < 7; l++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = xspeed1.Next(5, 20);
                sat2[l].x += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                sat2[l].DrawSatLeft(g);
            }
            for (int r = 0; r < 7; r++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = xspeed2.Next(5, 20);
                sat3[r].x -= rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                sat3[r].DrawSatRight(g);
            }
            foreach(Laser P in lasers)
            {
                P.drawlaser(g);
                P.movelaser(g);
            }
            Invalidate();
        }

        private void tmrSatellite_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                sat1[i].MoveSatellite();
                sat2[i].MoveSatellite(); //Move when the timer ticks
                sat3[i].MoveSatellite();

                if (pImage.pRec.IntersectsWith(sat1[i].satRec))
                {
                    //Reset planet[i] back to top of panel
                    sat1[i].y = 30; //Set y value of planetRec
                    health -= 1; //Lose a life
                    txtHealth.Text = health.ToString(); //Display number of lives
                    CheckLives();
                }
                if (pImage.pRec.IntersectsWith(sat2[i].satRec))
                {
                    //Reset planet[i] back to top of panel
                    sat2[i].x = 10; //Set y value of planetRec
                    health -= 1; //Lose a life
                    txtHealth.Text = health.ToString(); //Display number of lives
                    CheckLives();
                }
                if (pImage.pRec.IntersectsWith(sat3[i].satRec))
                {
                    //Reset planet[i] back to top of panel
                    sat3[i].x = 460; //Set y value of planetRec
                    health -= 1; //Lose a life
                    txtHealth.Text = health.ToString(); //Display number of lives
                    CheckLives();
                }
                //if a satellite reaches the bottom of the Game Area reposition it at the top
                if (sat1[i].y >= PnlStarlink.Height)
                {
                    sat1[i].y = 30;
                }
                if (sat2[i].x >= PnlStarlink.Width)
                {
                    sat2[i].x = 10;
                }
                if (sat3[i].x <= 0)
                {
                    sat3[i].x = 460;
                }
            }
            PnlStarlink.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void frmStarlink_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
            if (left)
            {
                pImage.rotationAngle -= 5;
            }
            if (right)
            {
                pImage.rotationAngle +=5;
            }
            //if (right) // if right arrow key pressed
            //{
            //    move = "right";
            //    pImage.MovePlayer(move);
            //}
            //if (left) // if left arrow key pressed
            //{
            //    move = "left";
            //    pImage.MovePlayer(move);
            //}
        }

        private void frmStarlink_Load(object sender, EventArgs e)
        {
            tmrPlayer.Enabled = false;
            tmrSatellite.Enabled = false;
            btnCheck.Enabled = false;
            //pImage.x = 200;
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            score = 0;
            LblScore.Text = score.ToString();
            health = int.Parse(txtHealth.Text); //Pass the health of the spacecraft to lives variable
            tmrPlayer.Enabled = true;
            tmrSatellite.Enabled = true;
            txtName.Enabled = false;
            txtHealth.Enabled = false;
        }

        private void PnlStarlink_MouseMove(object sender, MouseEventArgs e)
        {
            pImage.mousePlayer(e.X, e.Y);
        }

        private void PnlStarlink_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lasers.Add(new Laser(pImage.pRec, pImage.rotationAngle));
            }
        }

        private void tmrLaser_Tick(object sender, EventArgs e)
        {
            foreach(Satellite s1 in sat1)
            {
                foreach(Laser L in lasers)
                    if(s1.satRec.IntersectsWith(L.laserRec))
                    {
                        score += 1;
                        LblScore.Text = score.ToString();
                        s1.y = 30;
                        lasers.Remove(L);
                        break;
                    }
            }
            foreach (SatLeft s2 in sat2)
            {
                foreach (Laser L in lasers)
                    if (s2.satRec.IntersectsWith(L.laserRec))
                    {
                        score += 1;
                        LblScore.Text = score.ToString();
                        s2.x = 10;
                        lasers.Remove(L);
                        break;
                    }
            }
            foreach (SatRight s3 in sat3)
            {
                foreach (Laser L in lasers)
                    if (s3.satRec.IntersectsWith(L.laserRec))
                    {
                        score += 1;
                        LblScore.Text = score.ToString();
                        s3.x = 460;
                        lasers.Remove(L);
                        break;
                    }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmHighScores frmHighScore2 = new frmHighScores(txtName.Text, LblScore.Text);
            Hide();
            frmHighScore2.ShowDialog();
        }

        private void frmStarlink_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }
        private void CheckLives()
        {
            if (health == 0)
            {
                tmrPlayer.Enabled = false;
                tmrSatellite.Enabled = false;
                btnCheck.Enabled = true;
                MessageBox.Show("Game Over!");
            }
        }
    }
}
