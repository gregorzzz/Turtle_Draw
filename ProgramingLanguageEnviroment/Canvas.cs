using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Canvas
    {
        private Graphics g;
        private Pen Pen;
        private int xPos, yPos;
        private bool fill = false;
        
        public Canvas(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            Pen = new Pen(Color.Black, 1);
        }
        
        public Canvas()
        {
        }

        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(Pen, xPos, yPos, toX, toY);
            xPos = toX;
            yPos = toY;
        }

        public void DrawSquare(int width)
        {
            g.DrawRectangle(Pen, xPos, yPos, xPos +width, yPos + width);
            
            using (var brush = new SolidBrush(Pen.Color))
            {
                if (fill = true)
                {
                    g.FillRectangle(brush,xPos, yPos, xPos +width, yPos + width);
                }
            }
        }

        public void DrawCircle(float radius)
        {
            g.DrawEllipse(Pen, xPos , yPos, radius + radius, radius + radius);
            
            using (var brush = new SolidBrush(Pen.Color))
            {
                if (fill = true)
                {
                    g.FillEllipse(brush,xPos, yPos, xPos + radius, yPos + radius);
                }
            }
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
            
            using (var brush = new SolidBrush(Pen.Color))
            {
                if (fill = true)
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

        public void moveTo(int toX, int toY)
        {
            xPos = toX;
            yPos = toY;
        }
        
        public void ResetPen(int toX, int toY)
        {
            xPos = toX;
            yPos = toY;
        }

        public void PenColor(String color)
        {
            
           String[] colur = new string[] {
               "blue","red","green","yellow","orange","black"   
           };
           
           if (color == colur[0])
           {
               Pen = new Pen(Color.Blue, 1);
           }
           else if (color == colur[1])
           {
               Pen = new Pen(Color.Red, 1);
           }
           else if (color == colur[2])
           {
               Pen = new Pen(Color.Green, 1);
           }
           else if (color == colur[3])
           {
               Pen = new Pen(Color.Yellow, 1);
           }
           else if (color == colur[4])
           {
               Pen = new Pen(Color.Orange, 1);
           }
           else if (color == colur[5])
           {
               Pen = new Pen(Color.Black, 1);
           }
           
        }

        public void filll(bool filler)
        {
            if (filler){
                fill = true;
            }
            else
            {
                fill = false;
            }
            
        }
        
    }
}