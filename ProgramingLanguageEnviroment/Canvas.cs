using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Canvas
    {
        private Graphics g;
        public int xPos, yPos;
        public static bool fill = false;
        public PenColor colour; 

        public Canvas(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            colour = new PenColor();
            PenColor.Pen = new Pen(Color.Black, 1);

        }
        
       public Canvas()
        {
        }

        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(PenColor.Pen, xPos, yPos, toX, toY);
            xPos = toX;
            yPos = toY;
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
        
        public static void filll(bool filler)
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