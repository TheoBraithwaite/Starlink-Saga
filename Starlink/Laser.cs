using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Starlink
{
    class Laser
    {
        public int x, y, width, height;
        public int laserRotated;
        public double xSpeed, ySpeed;
        public Image laser;//variable for the laser's image
        public Rectangle laserRec;//variable for a rectangle to place our image in
        public Matrix matrixLaser;//matrix to enable us to rotate laser in the same angle as the spaceship
        Point centreLaser;//centre of laser
        // in the following constructor we pass in the values of spaceRec and the rotation angle of the spaceship
        // this gives us the position of the spaceship which we can then use to place the
        // laser where the spaceship is located and at the correct angle
        public Laser(Rectangle spaceRec, int laserRotate)
        {
            width = 20;
            height = 40;
            laser = Properties.Resources.laser1;
            laserRec = new Rectangle(x, y, width, height);
            //this code works out the speed of the laser to be used in the movelaser method
            xSpeed = 30 * (Math.Cos((laserRotate - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin((laserRotate + 90) * Math.PI / 180));
            //calculate x,y to move laser to middle of spaceship in drawlaser method
            x = spaceRec.X + spaceRec.Width / 2;
            y = spaceRec.Y + spaceRec.Height / 2;
            //pass laserRotate angle to laserRotated so that it can be used in the drawlaser method
            laserRotated = laserRotate;
        }

        public void drawlaser(Graphics g)
        {
            //centre laser 
            centreLaser = new Point(x, y);
            //instantiate a Matrix object called matrixlaser
            matrixLaser = new Matrix();
            //rotate the matrix (in this case laserRec) about its centre
            matrixLaser.RotateAt(laserRotated, centreLaser);
            //Set the current draw location to the rotated matrix point i.e. where laserRec is now
            g.Transform = matrixLaser;
            //Draw the laser
            g.DrawImage(laser, laserRec);

        }
        public void movelaser(Graphics g)
        {
            x += (int)xSpeed;//cast double to an integer value
            y -= (int)ySpeed;
            laserRec.Location = new Point(x, y);//lasers new location
        }
    }
}
