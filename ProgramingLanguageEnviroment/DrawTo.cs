using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class DrawTo
    {
        public Graphics g;
        public ShapeFill filler;
        public PenColor colour; 
        public int xPos, yPos;
        
        public DrawTo(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            filler = new ShapeFill();
            ShapeFill.fill = false;
            colour = new PenColor();
            PenColor.Pen = new Pen(Color.Black, 1);
        }
        
        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(PenColor.Pen, xPos, yPos, toX, toY);
            xPos = toX;
            yPos = toY;
        }
    }
}