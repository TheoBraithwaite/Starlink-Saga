using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Starlink
{
    class Satellite
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image satImage;//variable for the satellite's image

        public Rectangle satRec;//variable for a rectangle to place our image in
        public Matrix matrixSatellite;
        Point centreSatellite;
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Satellite()
        {
            x = 10;
            y = 10;
            width = 40;
            height = 40;
            //satImage contains the sat1.png image
            satImage = Properties.Resources.planet1;
            satRec = new Rectangle(x, y, width, height);
        }
        public void DrawSatellite(Graphics g)
        {
            g.DrawImage(satImage, satRec);
        }
    }
}
