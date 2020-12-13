using System;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Triangle class holds information that is displayed on the form when command is triggered by the factory
    /// </summary>
    public class Triangle:Shapes
    {
        int x;
        int y;
        int distance; 
        float angle;

        public Triangle() : base()
        {
        }
        
        /// <summary>
        /// Values on which the shape will be drawn from
        /// </summary>
        /// <param name="x">one side of triangle</param>
        /// <param name="y">one side of triangle</param>
        /// <param name="distance">the length between points x and y</param>
        /// <param name="angle">angle of which to draw triangle at</param>
        public Triangle (int x, int y, int distance, float angle) : base()
        {
            this.x = x;
            this.y = y;
            this.distance = distance;
            this.angle = angle;
        }

        /// <summary>
        /// Sets values need to draw a triangle
        /// </summary>
        /// <param name="list">user values which to draw from</param>
        public override void set(params int[] list)
        {
            base.set();
            this.x = list[0];
            this.y = list[1];
            this.distance = list[2];
            this.angle = list[3];
        }
        
        /// <summary>
        /// Draws triangle graphic
        /// </summary>
        /// <param name="g">Graphic to be drawn</param>
        public override  void Draw(Graphics g)
        {
            ShapeFill.fill = false;
            
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