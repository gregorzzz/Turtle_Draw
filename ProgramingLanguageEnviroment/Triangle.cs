﻿using System;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Triangle
    {
        public Graphics g;
        public Pen Pen;
        public Canvas canvas;
        private int xPos, yPos;
        
        public Triangle (Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            Pen = new Pen(Color.Black, 1);
            canvas = new Canvas();
            Canvas.fill = false;
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
                if (Canvas.fill == true)
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