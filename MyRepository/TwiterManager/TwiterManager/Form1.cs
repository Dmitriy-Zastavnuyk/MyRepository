using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace TwiterManager
{
    public partial class Form1 : Form
    {
        InfoICollector nws = new InfoICollector();
        
        TwitSender ms = new TwitSender();

        internal TwitSender Ms { get => ms; set => ms = value; }
        internal InfoICollector Nws { get => nws; set => nws = value; }
        internal String[] substrings ;


        public Form1()
        {
            InitializeComponent();
            
            
            listBox1.Items.Clear();
            foreach (DriveInfo d in Nws.AllDrives)
            {
                listBox1.Items.Add(Nws.GetDriveInfo(d));
            }
            substrings = Nws.MessageComposer().Split('@');
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendTwit_Click(object sender, EventArgs e)
        {
            
            Ms.SendTwit(substrings[0]);
            //здесь нужно вписать в первый параметр имя существующего пользователя
           // ms.SendDirectMessage("user", "Direct message for user");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ms.SendTwit(substrings[4]);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ms.SendTwit(substrings[1]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ms.SendTwit(substrings[2]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ms.SendTwit(substrings[3]);
        }
    }
}
