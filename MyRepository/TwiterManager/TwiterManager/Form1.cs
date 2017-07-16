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
        
        TweetHepler ms = new TweetHepler();

        internal TweetHepler Ms { get => ms; set => ms = value; }
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
            
            Ms.SendTweet(substrings[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ms.SendTweet(substrings[4]);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ms.SendTweet(substrings[1]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ms.SendTweet(substrings[2]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ms.SendTweet(substrings[3]);
        }

        private void getTweet_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var item in ms.GetTweet())
            {
                listBox2.Items.Add(item.ToString());
                Command com = new Command();
                com.GetCommand(item.Text);
                
                foreach (var i in com.GetClrCommands())
                {
                    switch (i.ToString())
                    {
                        case "1":
                            label1.Text = "0";
                            break;
                        case "2":
                            label2.Text = "0";
                            break;
                        case "3":
                            label3.Text = "0"; ;
                            break;
                        case "4":
                            label4.Text = "0"; ;
                            break;
                        default:
                            label1.Text = "-1";
                            label2.Text = "-1";
                            label3.Text = "-1";
                            label4.Text = "-1";
                            break;
                    }
                }
                foreach (var i in com.GetStCommands())
                {
                    switch (i.Key.ToString())
                    {
                        case "1":
                            label1.Text = i.Value.ToString();
                            break;
                        case "2":
                            label2.Text = i.Value.ToString(); ;
                            break;
                        case "3":
                            label3.Text = i.Value.ToString(); ;
                            break;
                        case "4":
                            label4.Text = i.Value.ToString(); ;
                            break;
                        default:
                            label1.Text = "-1";
                            label2.Text = "-1";
                            label3.Text = "-1";
                            label4.Text = "-1";
                            break;
                    }
                }
            }
            
        }
    }
}
