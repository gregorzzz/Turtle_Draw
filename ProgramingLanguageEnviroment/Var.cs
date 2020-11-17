using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Var class for variables
    /// Needs to be implemented
    /// </summary>
    public class Var
    {
        public Form1 formm;
        static Dictionary<string, int> dict = new Dictionary<string, int>();

        public static String comm;
        public static int value;
        
        public static void setVal(String c, int v)
        {
            comm = c;
            value = v;

        }
        
        public static void addVal()
        {
            bool exists = dict.ContainsKey(comm);
            if (exists)
            {
                dict.Remove(comm + value);
            }
            else
            {
                dict.Add(comm, value);
            }
        }
        
        
        
        
        
        
    }
}

