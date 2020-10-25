using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Circle
    {
        public Graphics g;
        public Canvas canvas;
        public PenColor colour; 
        public int xPos, yPos;
        
        public Circle(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            canvas = new Canvas();
            Canvas.fill = false;
            colour = new PenColor();
            PenColor.Pen = new Pen(Color.Black, 1);
        }
        
        public void DrawCircle(float radius)
        {
            g.DrawEllipse(PenColor.Pen, xPos , yPos, radius + radius, radius + radius);
            
            using (var brush = new SolidBrush(PenColor.Pen.Color))
            {
                if (Canvas.fill == true)
                {
                    g.FillEllipse(brush,xPos, yPos, radius + radius, radius + radius);
                }
            }
        }
    }
}