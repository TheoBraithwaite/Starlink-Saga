using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starlink
{
    public partial class frmStarlink : Form
    {
        Graphics g; //declare a graphics object called g
        Satellite[] sat1 = new Satellite[7];
        Player pImage = new Player();
        Random yspeed = new Random();
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
        }

        private void tmrSatellite_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                sat1[i].MoveSatellite();
                if (pImage.pRec.IntersectsWith(sat1[i].satRec))
                {
                    //Reset planet[i] back to top of panel
                    sat1[i].y = 30; //Set y value of planetRec
                    health -= 1; //Lose a life
                    txtHealth.Text = health.ToString(); //Display number of lives
                    CheckLives();
                }
                //if a satellite reaches the bottom of the Game Area reposition it at the top
                if (sat1[i].y >= PnlStarlink.Height)
                {
                        sat1[i].y = 30;
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
            if (right) // if right arrow key pressed
            {
                move = "right";
                pImage.MovePlayer(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                pImage.MovePlayer(move);
            }
        }

        private void frmStarlink_Load(object sender, EventArgs e)
        {
            tmrPlayer.Enabled = false;
            tmrSatellite.Enabled = false;
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            score = 0;
            LblScore.Text = score.ToString();
            health = int.Parse(txtHealth.Text); //Pass the health of the spacecraft to lives variable
            tmrPlayer.Enabled = true;
            tmrSatellite.Enabled = true;
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
                MessageBox.Show("Game Over!");
            }
        }
    }
}
