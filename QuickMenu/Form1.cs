using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuickMenu
{
    public partial class QuickPanel : Form
    {
        public QuickPanel()
        {

            InitializeComponent();

            ContextMenu contextMenu = new();

            MenuItem menuItemExit = new("Exit");
            menuItemExit.Click += new EventHandler(ExitMenuItem_Click);
            contextMenu.MenuItems.Add(menuItemExit);

            Waifu.ContextMenu = contextMenu;

            for (int i = 1; i < 11; i++)
            {
                string configKey = $"Button{i}-Label";

                string buttonName = Config.GetConfig(configKey);

                if (Controls.Find($"btn{i}", true).FirstOrDefault() is Button button)
                {

                    int defaultFontSize = 12;
                    int maxLength = 7;

                    int fontSize = defaultFontSize;
                    if(buttonName.Length > maxLength)
                    {
                        fontSize = (int)(defaultFontSize * ((double)maxLength / buttonName.Length));
                    }

                    button.Font = new Font(button.Font.FontFamily, fontSize + 1, button.Font.Style);

                    button.Text = buttonName;
                }
                AllEXES.Add(Path.GetFileNameWithoutExtension(Config.GetConfig($"Button{i}-Path")));


            }
            TopMost = true;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(Config.GetConfig("Button1-Path"), Config.GetConfig("Button1-Extra-Args"));
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Process.Start(Config.GetConfig("Button2-Path"), Config.GetConfig("Button2-Extra-Args"));
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Process.Start(Config.GetConfig("Button3-Path"), Config.GetConfig("Button3-Extra-Args"));
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Process.Start(Config.GetConfig("Button4-Path"), Config.GetConfig("Button4-Extra-Args"));
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Process.Start(Config.GetConfig("Button5-Path"), Config.GetConfig("Button5-Extra-Args"));
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Process.Start(Config.GetConfig("Button6-Path"), Config.GetConfig("Button6-Extra-Args"));
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Process.Start(Config.GetConfig("Button7-Path"), Config.GetConfig("Button7-Extra-Args"));
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Process.Start(Config.GetConfig("Button8-Path"), Config.GetConfig("Button8-Extra-Args"));
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Process.Start(Config.GetConfig("Button9-Path"), Config.GetConfig("Button9-Extra-Args"));
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Process.Start(Config.GetConfig("Button1-Path"), Config.GetConfig("Button10-Extra-Args"));
        }

        private static HashSet<string> AllEXES = new HashSet<string>();

        private void button1_Click_1(object sender, EventArgs e)
        {
            //List the programs you have started here dont add exe at the end just the name
            //This list will store all the exes you've opened with the quick access panel so you can kill them in the code below

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

        private void button2_Click(object sender, EventArgs e)
        {
            TestPage frm = new()
            {
                Location = Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.Show();
        }

        private void Waifu_DoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void Waifu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
