using System.Drawing;

namespace ProgramingLanguageEnviroment
{
   public abstract class Shapes:Shape
   {
       
       protected int xPos, yPos;
        
        public Shapes()
        {
            xPos = yPos = 100;
        }
        
        
        public abstract void Draw(Graphics g);

        public virtual void set(params int[] list)
        {
           
        }
        
    }
}