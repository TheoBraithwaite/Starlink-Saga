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
        Satellite sat1 = new Satellite(); //create the object, planet1

        public frmStarlink()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                planet1[i] = new Satellite();
            }
        }

        private void PnlStarlink_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            sat1.DrawSatellite(g);
        }
    }
}
