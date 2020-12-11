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
        public String[] commandList;
        //bitmap which is draw on and displayed in picturebox 
        Bitmap OutputBitmap = new Bitmap(640, 480);
        private Circle MyCircle;
        private Rectangle MyRectangle;
        private Triangle MyTriangle;
        private DrawTo MyLine;
        private int varVal;
        private String variable;
        private bool iloop = true;
        public int[] LoopArray;
        private int loopNum;
        private String lineComm;
        int LoopVal;
        String LoopComp;
        String LoopVar;
        int LoopVarVal;
        private int LoopStart = 1;
        private int LoopEnd = 0;


        //extract user input from textbox
        public String line;
        public Form1()
        {
            InitializeComponent();
            MyCircle = new Circle(Graphics.FromImage(OutputBitmap));//class for handling the drawing of circle 
            MyRectangle = new Rectangle(Graphics.FromImage(OutputBitmap));//class for handling the drawing of rectangle
            MyTriangle = new Triangle(Graphics.FromImage(OutputBitmap));//class for handling the drawing of Triangle 
            MyLine = new DrawTo(Graphics.FromImage(OutputBitmap));//class for handling the drawing of a line to move the pen 
            
            
        }
        /// <summary>
        /// Method for handling and triggering commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void command_line_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                line = inputBox.Text;
                //extract command from command line
                String command = command_line.Text.Trim().ToLower();
                commandList = command.Split(',',' ');
                command_line.Clear();

                // run command for executing commands in user input text area
                if (commandList[0].Equals("run") == true)
                {
                    using (StringReader reader = new StringReader(inputBox.Text))
                    {
                        while ((line = reader.ReadLine()) !=null)
                        {
                            commandList =line.Split(' ',',');
                            drawShape();
                        }
                    }
                }
                drawShape();
                Loop();
                Refresh();
            }
        }

        /// <summary>
        /// draws graphics on pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap,0,0);
        }

        /// <summary>
        /// method for clearing bitmap
        /// </summary>
        public void ClearImage()
        {
            Graphics myGraphics = Graphics.FromImage(OutputBitmap);
            myGraphics.Clear(Color.White);
            
        }

        /// <summary>
        /// method ResetPos resets pen position
        /// </summary>
        public void ResetPos()
        {
            ResetPen.resetPen(0, 0);
        }

        /// <summary>
        /// method SaveFiles saves text from input box uses dialog 
        /// </summary>
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

        /// <summary>
        /// method LoadFiles loads text to input box uses dialog  
        /// </summary>
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

        public void Loop()
        {
            for (int start = LoopStart; start < LoopEnd; start++)
            {
                line = LoopArray[start].ToString();
                commandList = line.Split(' ');
                loopNum = start;
                drawShape();
            }

            foreach (KeyValuePair<string, int> opp in Var.dict)
            {
                if (opp.Key.Equals(LoopVar))
                {
                    LoopVarVal = opp.Value;
                }
            }
        }
        

        /// <summary>
        /// method drawShape handles running commands
        /// </summary>
        public void drawShape()
        {
            if (iloop)
            {
                if (commandList[0].Equals("if"))
                {
                    String value = commandList[3];
                    String compVal = commandList[2];
                    String varbVal = commandList[1];
                    foreach (KeyValuePair<string, int> opp in Var.dict)
                    {
                        if (opp.Key.Equals(varbVal))
                        {
                            if (compVal.Equals("="))
                            {
                                if (opp.Value == int.Parse(value))
                                {
                                    iloop = true;
                                }
                                else
                                {
                                    iloop = false;
                                }
                            }

                            if (compVal.Equals(">"))
                            {
                                if (opp.Value > int.Parse(value))
                                {
                                    iloop = true;
                                }
                                else
                                {
                                    iloop = false;
                                }
                            }

                            if (compVal.Equals("<"))
                            {
                                if (opp.Value < int.Parse(value))
                                {
                                    iloop = true;
                                }
                                else
                                {
                                    iloop = false;
                                }
                            }
                        }
                    }
                }
                else if (commandList[0].Equals("endif"))
                {
                    iloop = true;
                }
                else if (commandList[0].Equals("while"))
                {
                    LoopVal = Int32.Parse(commandList[3]);
                    LoopComp = commandList[2];
                    LoopVar = commandList[1];
                    

                    if (LoopComp.Equals("=="))
                    {
                        while (LoopVarVal == LoopVal)
                        {
                            Loop();
                        }
                    }

                    else if (LoopComp.Equals(">"))
                    {
                        while (LoopVarVal > LoopVal)
                        {
                            Loop();
                        }
                    }

                    else if (LoopComp.Equals("<"))
                    {
                        while (LoopVarVal < LoopVal)
                        {
                            Loop();
                        }
                    }

                    else if (LoopComp.Equals("<="))
                    {
                        while (LoopVarVal <= LoopVal)
                        {
                            Loop();
                        }
                    }
                    else if (LoopComp.Equals(">="))
                    {
                        while (LoopVarVal >= LoopVal)
                        {
                            Loop();
                        }
                    }
                }
                else if (commandList[0].Equals("endloop"))
                {
                    LoopEnd = 2;
                    loopNum = LoopEnd;
                }
                
                else if (commandList[0].Equals("drawto") == true) // drawto command
                {
                    if (commandList.Length != 3) // checks for incorrect amount of values
                    {
                        MessageBox.Show("Wrong amount of values.\nExample: drawTo 50,50", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        foreach (KeyValuePair<string, int> opp in Var.dict)
                        {
                            if (commandList[1].Contains(opp.Key))
                            {
                                commandList[1] = opp.Value.ToString();
                            }

                            if (commandList[2].Contains(opp.Key))
                            {
                                commandList[2] = opp.Value.ToString();
                            }
                            
                        }
                        MyLine.DrawLine(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                    }
                }
                else if (commandList[0].Equals("rectangle") == true) // rectangle command 
                {
                    if (commandList.Length != 3) // checks for incorrect amount of values
                    {
                        MessageBox.Show("Wrong amount of values.\nExample: rectangle 50,50", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        foreach (KeyValuePair<string, int> opp in Var.dict)
                        {
                            if (commandList[1].Contains(opp.Key))
                            {
                                commandList[1] = opp.Value.ToString();
                            }

                            if (commandList[2].Contains(opp.Key))
                            {
                                commandList[2] = opp.Value.ToString();
                            }
                        }
                        MyRectangle.DrawSquare(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                    }
                }
                else if (commandList[0].Equals("circle") == true) // circle command 
                {
                    if (commandList.Length != 2) // checks for incorrect amount of values
                    {
                        MessageBox.Show("Wrong amount of values.\nExample: circle 50", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        foreach (KeyValuePair<string, int> opp in Var.dict)
                        {
                            if(commandList.Contains(opp.Key))
                            {
                                commandList[1] = opp.Value.ToString();
                            }
                        }
                        MyCircle.DrawCircle(int.Parse(commandList[1]));
                    }
                }
                else if (commandList[0].Equals("moveto") == true) // moveto command 
                {
                    if (commandList.Length != 3) // checks for incorrect amount of values
                    {
                        MessageBox.Show("Wrong amount of values.\nExample: moveto 50,50", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        foreach (KeyValuePair<string, int> opp in Var.dict)
                        {
                            if (commandList[1].Contains(opp.Key))
                            {
                                commandList[1] = opp.Value.ToString();
                            }

                            if (commandList[2].Contains(opp.Key))
                            {
                                commandList[2] = opp.Value.ToString();
                            }
                            
                        }
                        MoveTo.moveTo(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                    }
                }
                else if (commandList[0].Equals("triangle") == true) // triangle command
                {
                    if (commandList.Length != 5) // checks for incorrect amount of values
                    {
                        MessageBox.Show("Wrong amount of values.\nExample: triangle 150,150,100,30", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        foreach (KeyValuePair<string, int> opp in Var.dict)
                        {
                            if (commandList[1].Contains(opp.Key))
                            {
                                commandList[1] = opp.Value.ToString();
                            }

                            if (commandList[2].Contains(opp.Key))
                            {
                                commandList[2] = opp.Value.ToString();
                            }
                            
                            if (commandList[3].Contains(opp.Key))
                            {
                                commandList[3] = opp.Value.ToString();
                            }
                            
                            if (commandList[4].Contains(opp.Key))
                            {
                                commandList[4] = opp.Value.ToString();
                            }
                            
                        }
                        MyTriangle.DrawTriangle(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]),
                            Int32.Parse(commandList[3]), Int32.Parse(commandList[4]));
                    }
                }
                else if (commandList[0].Equals("clear") == true) // clear command 
                {
                    ClearImage();
                    canvas.Refresh();
                }
                else if (commandList[0].Equals("reset") == true) // reset command 
                {
                    ResetPos();
                    canvas.Refresh();
                }
                else if (commandList[0].Equals("pen") == true) // change pen colour command 
                {
                    PenColor.colorPen(commandList[1]);
                }
                else if (commandList[0].Equals("fill_on")) // turn fill on 
                {
                    ShapeFill.filll(true);
                }
                else if (commandList[0].Equals("fill_off")) // turn fill off
                {
                    ShapeFill.filll(false);
                }
                else if (commandList[0].Equals("save")) // save command 
                {
                    SaveFiles();
                }
                else if (commandList[0].Equals("load")) //load command
                {
                    LoadFiles();
                }
                else if (commandList[1].Equals("="))
                {
                    foreach (KeyValuePair<string, int> opp in Var.dict)
                    {
                        if (commandList[2].Contains(opp.Key))
                        {
                            commandList[2] = (opp.Value + int.Parse(commandList[4])).ToString();
                        }
                    }
                    
                    variable = commandList[0];
                    varVal = int.Parse(commandList[2]);
                    Var.setVal(commandList[0], varVal);
                    Var.addVal();
                    Var.printDictionary();
                    
                }

                else
                {
                    // checks for invalid commands 
                    var lineCount = inputBox.Lines.Count();

                    MessageBox.Show("Invalid command on line: " + lineCount, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (commandList[0].Equals("endif"))
                {
                    iloop = true;
                }

            }
                
            
            
        }
        
        /// <summary>
        /// button to run commands form inputbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runButton_Click(object sender, EventArgs e)
        {
            String line = inputBox.Text;
            
            using (StringReader reader = new StringReader(inputBox.Text))
            {
                while ((line = reader.ReadLine()) !=null)
                {
                    commandList =line.Split(' ',',');
                    drawShape();
                }
            }
            Refresh();
        }
    }
    
}