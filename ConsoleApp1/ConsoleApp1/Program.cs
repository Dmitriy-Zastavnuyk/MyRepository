using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ConsoleApp1
{
    class Program
    {
        static string ProcessInput(string s)
        {
            return s;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("s1");
            //Console.ReadLine();
            //string s1 = "evd";
            //Console.WriteLine("s2");
            //string s2 = "d";
            //Console.ReadLine();
            //Program.WriteToRegister(s1, s2);
            //Console.ReadLine();

            Console.WriteLine("Alert.exe invoked with the following parameters.\r\n");
            Console.WriteLine("Raw command-line: \n\t" + Environment.CommandLine);

            Console.WriteLine("\n\nArguments:\n");
            char[] ch = { '&',':','?'};
            foreach (string s in args)
            {
                String[] substrings = s.Split(ch);
                for (var i = 0; i < substrings.Length; i++) { Console.WriteLine(substrings[i]); }
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();


        }

        //static public void WriteToRegister(string uriSchemaName, string path)
        //{
        //    try
        //    {

        //        RegistryKey currentUserKey = Registry.ClassesRoot;
        //        RegistryKey subKey1 = currentUserKey.CreateSubKey(uriSchemaName,true);

        //        RegistryKey subKey11 = subKey1.CreateSubKey("DefaultIcon", true);
        //        subKey11.SetValue("(Default)", "C:\\Users\\Dima\\MyRepository\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\ConsoleApp1.exe"+","+"1");
        //        RegistryKey subKey12 = subKey1.CreateSubKey("shell", true);
        //        RegistryKey subKey2 = subKey12.CreateSubKey("open", true);

        //        RegistryKey subKey3 = subKey2.CreateSubKey("command", true);
        //        subKey3.SetValue("По умолчанию" , "C:\\Users\\Dima\\MyRepository\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\ConsoleApp1.exe" + "" + " \"%1\"");



        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error" + ex.Message);
        //    }
        //}
    }
}