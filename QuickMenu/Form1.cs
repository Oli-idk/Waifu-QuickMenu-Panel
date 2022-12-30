using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickMenu
{
    public partial class QuickPanel : System.Windows.Forms.Form
    {
        public QuickPanel()
        {
            InitializeComponent();
            //This allows the application to always be shown on top of any other application
            this.TopMost= true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Be sure to put the process as a path to where the exe is
            //Put what process you will be running or what link you want to open in here like this

            //Process.Start("\"C:\\Users\\3D Objects\\AccentColorizer.exe"");
            //Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");

            //Do this for each button you can have mutliple in one button, don't put too much or your pc will kill you

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {

        }

        private static HashSet<string> AllEXES = new HashSet<string>();

        private void button1_Click_1(object sender, EventArgs e)
        {
            //List the programs you have started here dont add exe at the end just the name
            //This list will store all the exes you've opened with the quick access panel so you can kill them in the code below

            AllEXES.Add("");
            AllEXES.Add("");
            AllEXES.Add("");
            AllEXES.Add("");
            AllEXES.Add("");
            AllEXES.Add("");
            AllEXES.Add("");
            AllEXES.Add("");
            AllEXES.Add("");
            AllEXES.Add("");
            AllEXES.Add("");

            //Kills any program that you have in the list above
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                if (AllEXES.Contains(process.ProcessName))
                {
                    process.Kill();
                }
            }
        }
        
    }
}
