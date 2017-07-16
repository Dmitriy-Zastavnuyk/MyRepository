using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tweetinvi;


namespace TwiterManager
{
    class Command
    {
        private  ArrayList clr = new ArrayList();
        private Dictionary<string, string> st = new Dictionary<string, string>();
        public void GetCommand(string str)
        {
            
            //string pattern1 = @"\b(clr)\b";
            //string pattern2 = @"\b(st)\b";
            //string pattern3 = @"\[([^\[\]]+)\]";
            //string pattern4 = @"\(([^\[\]]+)\)";

            //Regex regex1 = new Regex(pattern1, RegexOptions.IgnoreCase);
            //Regex regex2 = new Regex(pattern2, RegexOptions.IgnoreCase);

            char[] separator = {' '};
            string[] arr = str.Split(separator);
            foreach (var item in arr )
            {
                char[] s1 = { '.' };
                string[] a = item.Split(s1);
                if (a[0]=="clr")
                {
                    clr.Add(a[1]);
                }
                else if (a[0] == "st")
                {
                    char[] s2 = { ':' };
                    string[] b = a[1].Split(s2);
                    st.Add(b[0],b[1]);
                }

            }

            //if (regex1.IsMatch(str))
            //{

            //    clr.Add(Regex.Match(str, pattern4));

            //}
            //if (regex2.IsMatch(str))
            //{ 
            //    st.Add(Regex.Match(str, pattern4).ToString(), Regex.Match(str, pattern3).ToString());

            //}

        }

        public ArrayList GetClrCommands()
        {
            return clr;
        }
        public Dictionary<string, string> GetStCommands()
        {
            return st;
        }
    }
}
