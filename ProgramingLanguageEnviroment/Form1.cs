using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramingLanguageEnviroment
{
    public partial class Form1 : Form
    {
       
        Bitmap OutputBitmap = new Bitmap(640, 480);
        Canvas MyCanvas;
        public Form1()
        {
            InitializeComponent();
            MyCanvas = new Canvas(Graphics.FromImage(OutputBitmap));
        }
        

        private void command_line_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String Command = command_line.Text.Trim().ToLower();
                if (Command.Equals("line") == true)
                {
                    MyCanvas.DrawLine(160, 120);
                }
                else if (Command.Equals("square") == true)
                {
                    MyCanvas.DrawSquare(25);
                }
                else if (Command.Equals("circle") == true)
                {
                    MyCanvas.DrawCircle(50);
                }
                Refresh();
            }
            

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap,0,0);
        }
    }
    
}