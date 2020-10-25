using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Canvas
    {
        private Graphics g;
        public Pen Pen;
        public int xPos, yPos;
        public static bool fill = false;
        public Circle circle;

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