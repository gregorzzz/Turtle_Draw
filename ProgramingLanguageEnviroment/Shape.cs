using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public interface Shape
    {
        void set(params int[] list);
        void Draw(Graphics g);

    }
}