using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivestreamerLauncher
{
    public partial class Form1 : Form
    {
        string livestreamerDir;
        ProcessStartInfo livestreamer = new ProcessStartInfo();
        public Form1(string livestreamerDir)
        {
            this.livestreamerDir = livestreamerDir;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void launch()
        {
            if (String.IsNullOrEmpty(livestreamerDir))
                livestreamer.FileName = "livestreamer";
            else
                livestreamer.FileName = livestreamerDir;
            livestreamer.WindowStyle = ProcessWindowStyle.Normal;
            livestreamer.CreateNoWindow = false;
            livestreamer.RedirectStandardOutput = false;
            livestreamer.UseShellExecute = true;
            Process.Start(livestreamer);
            this.Close();
        }
        
        private void buttonBest_Click(object sender, EventArgs e)
        {
            livestreamer.Arguments += " best";
            launch();
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            launch();
        }

        private void textBox1_Validating(object sender, EventArgs e)
        {
            livestreamer.Arguments = textBox1.Text;
        }

        private void buttonQualities_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(livestreamerDir))
                livestreamer.FileName = "livestreamer";
            else
                livestreamer.FileName = livestreamerDir;
            livestreamer.RedirectStandardOutput = true;
            livestreamer.CreateNoWindow = true;
            livestreamer.UseShellExecute = false;
            var ls = Process.Start(livestreamer);
            string output = ls.StandardOutput.ReadToEnd();
            ls.WaitForExit();
            ls.Close();
            if (!output.Contains("Available streams:"))
                return;

            output = output.Remove(0, output.IndexOf("Available streams:") + 19);
            output = output.Replace("\r\n", "");
            Create_buttons(output);
        }

        private void Create_buttons(string quality)
        {
            string[] qualities = quality.Split(',');
            for (int i = 0; i < qualities.Length; i++)
            {
                if (qualities[i].Contains('('))
                    qualities[i] = qualities[i].Remove(qualities[i].IndexOf('('));
                qualities[i] = qualities[i].Trim();
            }

            qualityButtons.ColumnCount = qualities.Length;
            qualityButtons.Controls.Clear();
            foreach (ColumnStyle style in qualityButtons.ColumnStyles)
                style.SizeType = SizeType.AutoSize;
            for (int i = 0; i < qualities.Length; i++)
            {
                Button b = new Button();
                b.Name = qualities[i];
                b.Text = qualities[i];
                b.AutoSize = true;
                b.Click += new System.EventHandler(qualityButton_click);
                qualityButtons.Controls.Add(b, i, 0);
            }
        }
        private void qualityButton_click(Object sender, System.EventArgs e)
        {
            Button butt;
            if (sender is Button)
                butt = (Button)sender;
            else
                return;
            livestreamer.Arguments += (" " + butt.Name);
            launch();
        }

    }
}
