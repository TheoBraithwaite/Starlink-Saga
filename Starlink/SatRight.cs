using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Starlink
{
    class SatRight
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image satImage;//variable for the satellite's image

        public Rectangle satRec;//variable for a rectangle to place our image in
        public Matrix matrixSatellite;
        Point centreSatellite;
        public int score;
        public int satRotate;
        Point centre;
        //Create a constructor (initialises the values of the fields)
        public SatRight(int spacing)
        {
            x = 430;
            y = spacing;
            width = 60;
            height = 60;
            //satImage contains the sat1.png image
            satImage = Properties.Resources.spacex2;
            satRec = new Rectangle(x, y, width, height);
        }
        public void DrawSatRight(Graphics g)
        {
            //find the centre point of spaceRec
            centre = new Point(satRec.X + width / 2, satRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrixSatellite = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrixSatellite.RotateAt(satRotate, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrixSatellite;
            //draw the spaceship
            g.DrawImage(satImage, satRec);
        }
        public void MoveSatellite()
        {
            satRec.Location = new Point(x, y);
        }
    }
}
