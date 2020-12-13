using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Interface for shapes inheritance 
    /// </summary>
    public interface Shape
    {
        void set(Color colour, params int[] list);
        void Draw(Graphics g);

    }
}