using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Serach_Engine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("about:blank");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("about:blank");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "blank")
                webBrowser1.Navigate("about:blank");
            if (textBox1.Text == "bing")
                webBrowser1.Navigate("bing.com");
            if (textBox1.Text == "help")
                webBrowser1.DocumentText = "See Help HTML page for Serach Engine.\n Download HTML page";
            if (textBox1.Text == "google")
                webBrowser1.Navigate("google.com");
            if (textBox1.Text == "duckduckgo")
                webBrowser1.Navigate("https://duckduckgo.com/");
            if (textBox1.Text == "youtube")
                webBrowser1.Navigate("youtube.com");
            if (textBox1.Text == "dailymotion")
                webBrowser1.Navigate("https://www.dailymotion.com/us");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "blank")
                webBrowser2.Navigate("about:blank");
            if (textBox2.Text == "bing")
                webBrowser2.Navigate("bing.com");
            if (textBox2.Text == "help")
                webBrowser2.DocumentText = "See Help HTML page for Serach Engine.\n Download HTML page";
            if (textBox2.Text == "google")
                webBrowser2.Navigate("google.com");
            if (textBox2.Text == "duckduckgo")
                webBrowser2.Navigate("https://duckduckgo.com/");
            if (textBox2.Text == "youtube")
                webBrowser2.Navigate("youtube.com");
            if (textBox2.Text == "dailymotion")
                webBrowser2.Navigate("https://www.dailymotion.com/us");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}