using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Circle
    {
        private Graphics g;
        private Pen Pen;
        private int xPos, yPos;
        private bool fill = false;
        
        public Circle(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            Pen = new Pen(Color.Black, 1);
        }
        
        public void DrawCircle(float radius)
        {
            g.DrawEllipse(Pen, xPos , yPos, radius + radius, radius + radius);
            
            using (var brush = new SolidBrush(Pen.Color))
            {
                if (fill == true)
                {
                    g.FillEllipse(brush,xPos, yPos, xPos + radius, yPos + radius);
                }
            }
        }
    }
}