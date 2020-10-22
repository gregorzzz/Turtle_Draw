using System;
using NUnit.Framework;
using ProgramingLanguageEnviroment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Form_Test
{
    [TestClass]
    public class Tests
    {
        private Canvas _canvas = new Canvas(); // call new instance of canvas

        [TestMethod]
        public void Test1()
        {
            Assert.True(true);
        }
    }

