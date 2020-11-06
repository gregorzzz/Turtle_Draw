using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Is turned on and off by command 
    /// </summary>
    public class ShapeFill
    {
        public static bool fill = false;

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