using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Stores user defined variables in dictionary
    /// </summary>
    public class Var
    {
        public Form1 formm;
        //dictionary used for storing variables
        public static Dictionary<string, int> dict = new Dictionary<string, int>();

        public static String comm;
        public static int value;
        
        /// <summary>
        /// Sets the variable name and value to be added
        /// </summary>
        /// <param name="var">Variable name</param>
        /// <param name="val">Variable value</param>
        public static void setVal(String var, int val)
        {
            comm = var;
            value = val;
            

        }
        
        /// <summary>
        /// Adds variable to dictionary
        /// </summary>
        public static void addVal()
        {
            // if variable exists replace with new defection 
            bool exists = dict.ContainsKey(comm);
            if (exists)
            {
                dict.Remove(comm);
            }
         
            dict.Add(comm, value);

        }
        
        public static void printDictionary()
      {
        foreach (KeyValuePair<string, int> key1 in dict)

        {
            Console.WriteLine(key1.Key + key1.Value);

        }

      }
        
    }
}

