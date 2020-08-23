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

                //if a satellite reaches the bottom of the Game Area reposition it at the top
                if (sat1[i].y >= PnlStarlink.Height)
                {
                    sat1[i].y = 30;
                }
            }
            PnlStarlink.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}
