﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramingLanguageEnviroment
{
    public partial class Form1 : Form
    {
        private String[] commandList;
        Bitmap OutputBitmap = new Bitmap(640, 480);
        private Canvas MyCanvas;
        public Form1()
        {
            InitializeComponent();
            MyCanvas = new Canvas(Graphics.FromImage(OutputBitmap));
        }
        

        private void command_line_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String command = command_line.Text.Trim().ToLower();
                commandList = command.Split(' ');
                if (commandList[0].Equals("line") == true)
                {
                    MyCanvas.DrawLine(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                }
                else if (commandList[0].Equals("square") == true)
                {
                    MyCanvas.DrawSquare(Int32.Parse(commandList[1]));
                }
                else if (commandList[0].Equals("circle") == true)
                {
                    MyCanvas.DrawCircle(Int32.Parse(commandList[1]));
                }
                else if (commandList[0].Equals("move") == true)
                {
                    MyCanvas.moveTo(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                }
                else if (commandList[0].Equals("triangle") == true)
                {
                    MyCanvas.DrawTriangle(Int32.Parse(commandList[1]),Int32.Parse(commandList[2]),Int32.Parse(commandList[3]), Int32.Parse(commandList[4]));
                }
                else if (commandList[0].Equals("clear") == true)
                {
                    ClearImage();
                    canvas.Refresh();
                }
                else if(commandList[0].Equals("reset") == true)
                {
                    ResetPos();
                    canvas.Refresh();
                }
                else if (commandList[0].Equals("pen") == true)
                {
                    MyCanvas.PenColor(commandList[1]);
                }
                else if (commandList[0].Equals("fill on"))
                {
                    MyCanvas.filll(true);
                }
                else if (commandList[0].Equals("fill off"))
                {
                    MyCanvas.filll(false);
                }
                else if (commandList[0].Equals("save"))
                {
                    SaveFiles();
                }
                else if (commandList[0].Equals("load"))
                {
                    LoadFiles();
                }
                
                Refresh();
            }
            

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap,0,0);
        }

        public void ClearImage()
        {
            Graphics myGraphics = Graphics.FromImage(OutputBitmap);
            myGraphics.Clear(Color.White);
            
        }

        public void ResetPos()
        {
            MyCanvas.ResetPen(0, 0);
          
        }

        public void SaveFiles()
        {

            SaveFileDialog saveFileBox = new SaveFileDialog();

            saveFileBox.DefaultExt = "*.txt";
            saveFileBox.Filter = "Text Document|*.txt";

            if (saveFileBox.ShowDialog() == System.Windows.Forms.DialogResult.OK && 
                saveFileBox.FileName.Length > 0)
            {
                inputBox.SaveFile(saveFileBox.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        public void LoadFiles()
        {
            OpenFileDialog loadFileBox = new OpenFileDialog();

            loadFileBox.DefaultExt = "*.txt";
            loadFileBox.Filter = "Text Document|*.txt";

            if (loadFileBox.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                loadFileBox.FileName.Length > 0)
            {
                inputBox.LoadFile(loadFileBox.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        
    }
    
}