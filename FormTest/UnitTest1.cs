using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using ProgramingLanguageEnviroment;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace FormTest
{
   
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Test MoveTo
        /// Testing if xPos and yPos change
        /// </summary>
        [TestMethod]
        public void TestValidMoveToCommand()
        {
            String draw = "moveto 100 200";
            String[] commandList;
            commandList = draw.Split(' ');
            int xPos = 100;
            int yPos = 200;

            MoveTo.moveTo(int.Parse(commandList[1]), int.Parse(commandList[2]));

            Assert.AreEqual(xPos, MoveTo.xPos);
            Assert.AreEqual(yPos, MoveTo.yPos);

        }

        /// <summary>
        /// Test DrawTo
        /// Testing if a line is drawn of given points
        /// </summary>
        [TestMethod]
        public void TestValidDrawToCommand()
        {
            String draw = "drawto 30 80";
            String[] commandList;
            commandList = draw.Split(' ');
            int toX = 30;
            int toY = 80;

            if (commandList[0].Equals("drawto"))
            {
                MoveTo.moveTo(int.Parse(commandList[1]), int.Parse(commandList[2]));
            }

            Assert.AreEqual(toX, MoveTo.xPos);
            Assert.AreEqual(toY, MoveTo.yPos);

        }

        /// <summary>
        /// Test DrawTo
        /// Testing if exception is thrown on invalid input
        /// </summary>
        [TestMethod]
        public void TestInvalidDrawToCommand()
        {
            String command ="drawto 50" ;
            String[] commandList;
            commandList = command.Split(' ');
            
            try
            {
                if (commandList[0].Equals("drawto"))
                {
                    MoveTo.moveTo(int.Parse(commandList[1]), int.Parse(commandList[2]));
                }
            }
            catch (IndexOutOfRangeException e)
            {
                command = e.Message;
            }

            Assert.AreEqual("Index was outside the bounds of the array.", command);

        }

        /// <summary>
        /// Test ResetPen
        /// Testing to see if pen goes back to its default position
        /// </summary>
        [TestMethod]
        public void TestPenResetPosition()
        {
            String draw = "reset";
            String[] commandList;
            commandList = draw.Split(' ');
            MoveTo.xPos = 60;
            MoveTo.yPos = 90;
            int toX = 0;
            int toY = 0;

            ResetPen.resetPen(0, 0);

            Assert.AreEqual(toX, MoveTo.xPos);
            Assert.AreEqual(toY, MoveTo.yPos);
        }

        /// <summary>
        /// Test PenColor
        /// test pen colour changes by changing pens color
        /// </summary>
        [TestMethod]
        public void TestPenColorChange()
        {
            String command = "pen green";
            String[] commandList;
            commandList = command.Split(' ');
            Pen scribble;
            scribble = new Pen(Color.Green, 1);
            
            PenColor.colorPen(commandList[1]);
            
            Assert.AreEqual(scribble.Color, PenColor.Pen.Color);
        }

        /// <summary>
        /// Test Var
        /// testing to see if variable changes
        /// </summary>
        [TestMethod]
        public void TestVar()
        {
            String draw = "number = 10";
            String[] commandList;
            commandList = draw.Split(' ');
            String variable;
            int varVal;
            int val = 10;
            if (commandList[1].Equals("="))
            {
                variable = commandList[0];
                varVal = int.Parse(commandList[2]);
                Var.setVal(commandList[0], varVal);
                Var.addVal();
                Var.printDictionary();
            }
            
            Assert.AreEqual(val,Var.value);
        }
        /// <summary>
        /// Test If Statement
        /// testing to see if statement will run
        /// by checking if iloop if true 
        /// </summary>
        [TestMethod]
        public void TestIfStatement()
        {
            String draw = "if number = 10";
            String[] commandList;
            commandList = draw.Split(' ');
            bool iloop = true;
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
                        }
                    }
                }
                
                Assert.IsTrue(iloop);
            }

        }

        /// <summary>
        /// Tests an invalid shapeType in factory to see if factory will draw a shape or return an error
        /// </summary>
        [TestMethod]
        public void TestInvalidFactory()
        {
            String error = "";
            Factory f = new Factory();
            try
            {
                Object o = (Object) f.getCommand("invalid");
            }
            catch (ArgumentException e)
            {
                error = e.Message;
            }
            
            Assert.AreEqual("Factory error: command does not exist", error);
        }
        
    }
}