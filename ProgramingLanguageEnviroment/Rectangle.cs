using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Rectangle
    {
        public Graphics g;
        public Canvas canvas;
        public PenColor colour; 
        private int xPos, yPos;
        
        public Rectangle(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            canvas = new Canvas();
            Canvas.fill = false;
            colour = new PenColor();
            PenColor.Pen = new Pen(Color.Black, 1);

        }
        public void DrawSquare(int width, int height)
        {
            g.DrawRectangle(PenColor.Pen, xPos, yPos, xPos + width, yPos + height);
            
            using (var brush = new SolidBrush(PenColor.Pen.Color))
            {
                if (Canvas.fill == true)
                {
                    g.FillRectangle(brush,xPos, yPos, xPos + width, yPos + height);
                }
            }
        }
    }
        
}