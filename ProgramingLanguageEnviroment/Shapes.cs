using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Class inherits all of the shape classes 
    /// </summary>
   public abstract class Shapes:Shape
   {
       
       protected int xPos, yPos;
        
       /// <summary>
       /// Predefined values
       /// </summary>
        public Shapes()
        {
            xPos = yPos = 100;
        }
        
        /// <summary>
        /// Method which needs to be implemented
        /// </summary>
        /// <param name="g">Graphic which will be drawn</param>
        public abstract void Draw(Graphics g);

        /// <summary>
        /// Used for setting shape specific values 
        /// </summary>
        /// <param name="list">stored parameters</param>
        public virtual void set(params int[] list)
        {
           
        }
        
    }
}