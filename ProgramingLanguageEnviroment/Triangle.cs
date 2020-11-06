using System;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Triangle class holds information that is displayed on the form when command is triggered
    /// </summary>
    public class Triangle
    {
        public Graphics g;
        public ShapeFill filler;
        public PenColor colour; 
        private int xPos, yPos;
        
        /// <summary>
        /// Constructor initialises Triangle to Pen or ShapeFill 
        /// </summary>
        /// <param name="g">Graphics place to draw on</param>
        public Triangle (Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            filler = new ShapeFill();//triggers fill on or off 
            ShapeFill.fill = false;
            colour = new PenColor();
            PenColor.Pen = new Pen(Color.Black, 1);//default pen
        }
        
        /// <summary>
        /// draws a triangle from user input 
        /// </summary>
        /// <param name="x">one side of triangle </param>
        /// <param name="y">one side of triangle</param>
        /// <param name="distance">the length between points x and y</param>
        /// <param name="angle">angle of which to draw triangle at</param>
        public void DrawTriangle(int x, int y, int distance, float angle)
        {
            //calculates triangle points and angle 
            PointF[] pnt = new PointF[3];
            pnt[0].X = x;

            pnt[0].Y = y;

            pnt[1].X = (float)( x + distance * Math.Cos(angle));

            pnt[1].Y = (float)( y + distance * Math.Sin(angle));

            pnt[2].X = (float)( x + distance * Math.Cos(angle + Math.PI / 3));

            pnt[2].Y = (float)( y + distance * Math.Sin(angle + Math.PI / 3));  
            //draws triangle at points 
            g.DrawPolygon(PenColor.Pen, pnt);
            
            using (var brush = new SolidBrush(PenColor.Pen.Color))// brush for drawing graphic filled
            
            {
                if (ShapeFill.fill == true)// draws filled graphic when triggered 
                {
                    pnt = new PointF[3];
                    pnt[0].X = x;

                    pnt[0].Y = y;

                    pnt[1].X = (float)( x + distance * Math.Cos(angle));

                    pnt[1].Y = (float)( y + distance * Math.Sin(angle));

                    pnt[2].X = (float)( x + distance * Math.Cos(angle + Math.PI / 3));

                    pnt[2].Y = (float)( y + distance * Math.Sin(angle + Math.PI / 3));  
            
                    g.FillPolygon(brush, pnt);
                }
            }
        }
    }
}