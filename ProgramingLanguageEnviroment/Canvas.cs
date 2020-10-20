using System;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Canvas
    {
        private Graphics g;
        private Pen Pen;
        private int xPos, yPos;
        public Canvas(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            Pen = new Pen(Color.Black, 1);
        }

        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(Pen, xPos, yPos, toX, toY);
            xPos = toX;
            yPos = toY;
        }

        public void DrawSquare(int width)
        {
            g.DrawRectangle(Pen, xPos, yPos, xPos +width, yPos +width);
        }

        public void DrawCircle(float radius)
        {
            g.DrawEllipse(Pen, xPos , yPos, radius + radius, radius + radius);
        }

        public void DrawTriangle(int x, int y, int distance, float angle)
        {
            //float angle = 0;
            PointF[] pnt = new PointF[3];
            pnt[0].X = x;

            pnt[0].Y = y;

            pnt[1].X = (float)( x + distance * Math.Cos(angle));

            pnt[1].Y = (float)( y + distance * Math.Sin(angle));

            pnt[2].X = (float)( x + distance * Math.Cos(angle + Math.PI / 3));

            pnt[2].Y = (float)( y + distance * Math.Sin(angle + Math.PI / 3));  
            
            g.DrawPolygon(Pen, pnt);
        }

        public void moveTo(int toX, int toY)
        {
            xPos = toX;
            yPos = toY;
        }
        
    }
}