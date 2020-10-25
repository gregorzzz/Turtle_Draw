using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Rectangle
    {
        public Graphics g;
        public Pen Pen;
        public Canvas canvas;
        private int xPos, yPos;
        
        public Rectangle(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            Pen = new Pen(Color.Black, 1);
            canvas = new Canvas();
            Canvas.fill = false;
        }
        public void DrawSquare(int width, int height)
        {
            g.DrawRectangle(Pen, xPos, yPos, xPos +width, yPos + height);
            
            using (var brush = new SolidBrush(Pen.Color))
            {
                if (Canvas.fill == true)
                {
                    g.FillRectangle(brush,xPos, yPos, xPos + width, yPos + height);
                }
            }
        }
    }
        
}