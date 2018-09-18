using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Anime_DL_Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            string user = textBox1.Text;
            string pass = textBox2.Text;
            string url = textBox3.Text;
            string res = textBox4.Text;
            int inicial = (int)numericUpDown1.Value;
            int fim = (int)numericUpDown2.Value;
            p.StartInfo.FileName = "cmd";
            if (checkBox2.Checked == false && checkBox1.Checked == false)
            {
                p.StartInfo.Arguments = "/c anime-dl.exe -i " + url + " -u " + user + " -p " + pass + " -r " + res;
            }
            else if (checkBox2.Checked == true && checkBox1.Checked == false)
            {
                p.StartInfo.Arguments = "/c anime-dl.exe -i " + url + " -u " + user + " -p " + pass + " --skip";
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                p.StartInfo.Arguments = "/c anime-dl.exe -i " + url + " -u " + user + " -p " + pass + " -r " + res + " --range " + inicial + "-" + fim;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                p.StartInfo.Arguments = "/c anime-dl.exe -i " + url + " -u " + user + " -p " + pass + " -r " + res + " --skip" + " --range " + inicial + "-" + fim;
            }
            p.Start();
        }
    }
}
