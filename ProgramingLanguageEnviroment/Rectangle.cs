using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Rectangle
    {
        public Graphics g;
        public ShapeFill filler;
        public PenColor colour; 
        private int xPos, yPos;
        
        public Rectangle(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            filler = new ShapeFill();
            ShapeFill.fill = false;
            colour = new PenColor();
            PenColor.Pen = new Pen(Color.Black, 1);

        }
        public void DrawSquare(int width, int height)
        {
            g.DrawRectangle(PenColor.Pen, MoveTo.xPos , MoveTo.yPos, xPos + width, yPos + height);
            
            using (var brush = new SolidBrush(PenColor.Pen.Color))
            {
                if (ShapeFill.fill == true)
                {
                    g.FillRectangle(brush,MoveTo.xPos , MoveTo.yPos, xPos + width, yPos + height);
                }
            }
        }
    }
        
}