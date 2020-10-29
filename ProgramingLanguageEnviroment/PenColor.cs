using System;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class PenColor
    {
        public Graphics g;
        public static Pen Pen;
        public ShapeFill filler;
        private int xPos, yPos;
        
        public PenColor(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            Pen = new Pen(Color.Black, 1);
            filler = new ShapeFill();
            ShapeFill.fill = false;
        }

        public PenColor()
        {
        }
        
        public static void colorPen(String color)
        {
            
            String[] colur = new string[] {
                "red","green","blue","yellow","orange","black"   
            };
           
            if (color == colur[0])
            {
                Pen = new Pen(Color.Red, 1);
            }
            else if (color == colur[1])
            {
                Pen = new Pen(Color.Green, 1);
            }
            else if (color == colur[2])
            {
                Pen = new Pen(Color.Blue, 1);
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
    }
}