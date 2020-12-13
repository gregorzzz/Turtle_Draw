using System;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// PenColor class keeps hold of possible pen colours changes when command is triggered 
    /// </summary>
    public class PenColor
    {
        
        public static Pen Pen;

        /// <summary>
        /// Changes colour of pen
        /// </summary>
        /// <param name="color"> chosen pen colour</param>
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