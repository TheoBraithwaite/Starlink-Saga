using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Starlink
{
    class Player
    {
        public int x, y, width, height; //Variables for the rectangle
        public Image pImage; //Variable for the player's image
        public Rectangle pRec;//variable for a rectangle to place our image in
        public int score;
        public int rotationAngle;
        public Matrix matrix;
        Point centre;
        //Create a constructor (initialises the values of the fields)
        public Player()
        {
            //x = 230;
            //y = 370;
            width = 40;
            height = 40;
            //pImage contains the player image, starfighter
            pImage = Properties.Resources.starfighter;
            pRec = new Rectangle(x, y, width, height);
        }
        public void DrawPlayer(Graphics g)
            {
                //find the centre point of spaceRec
                centre = new Point(pRec.X + width / 2, pRec.Y + width / 2);
                //instantiate a Matrix object called matrix
                matrix = new Matrix();
                //rotate the matrix (spaceRec) about its centre
                matrix.RotateAt(rotationAngle, centre);
                //Set the current draw location to the rotated matrix point
                g.Transform = matrix;
                //draw the spaceship

                g.DrawImage(pImage, pRec);
            }
        public void MovePlayer(string move)
        {
            //{
            //    if (move == "right")
            //    {
            //        if (pRec.Location.X > 450) //Is spaceship within 50 of right side
            //        {
            //            x = 450;
            //            pRec.Location = new Point(x, y);
            //        }
            //        else
            //        {
            //            x += 5;
            //            pRec.Location = new Point(x, y);
            //        }
            //    }
            //    if (move == "left")
            //    {
            //        if (pRec.Location.X < 10) //Is spaceship within 10 of left side
            //        {
            //            x = 10;
            //            pRec.Location = new Point(x, y);
            //        }
            //        else
            //        {
            //            x -= 5;
            //            pRec.Location = new Point(x, y);
            //        }
            //    }
            //}
        }
        public void mousePlayer(int mouseX, int mouseY)
        {
            pRec.X = mouseX - (pRec.Width / 2);
            pRec.Y = mouseY - (pRec.Height / 2);
        }
    }
}
