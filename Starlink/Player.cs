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
        public Image pImage; //Variable for the planet's image
        public Rectangle pRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Player()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            //pImage contains the player image, craft1
            pImage = Properties.Resources.alien1;
            pRec = new Rectangle(x, y, width, height);
        }
        public void DrawPlayer(Graphics g)
        {
            g.DrawImage(pImage, pRec);
        }
    }
}
