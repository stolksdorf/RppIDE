using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RppLibrary;

namespace Rpp_IDE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            Compile();
        }

        private void Compile()
        {
            RppCode temp = new RppCode(tbRpp.Lines);
            Text = "R++ Compiler IDE - " + temp.Version;

            lbFunctions.Items.Clear();
            foreach (FuncClass tempFunc in temp.Functions)            
                lbFunctions.Items.Add(tempFunc.Name);

            tbErrors .Text = "";
            foreach (ErrorClass error in temp.Errors)
                tbErrors.Text += error.Location + " : " + error.Description + " : " + error.Code + Environment.NewLine;


            tbRsl.Lines = Tab(temp.RSLCode);
        }

        private void tbRpp_TextChanged(object sender, EventArgs e)
        {
            if (cbCompile.Checked) Compile();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbRpp.Text = "";
                StreamReader SR;
                string templine;
                SR = File.OpenText(openFileDialog1.FileName);
                templine = SR.ReadLine();
                while (templine != null)
                {
                    tbRpp.Text += templine + Environment.NewLine;
                    templine = SR.ReadLine();
                }
                SR.Close();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog1.FileName);
                foreach (string line in tbRsl.Lines)
                    SW.WriteLine(line);
                SW.Close();
            }
        }

        //Autotabber for the editor side
        private string[] Tab(string[] code)
        {
            List<string> result = new List<string>();

            int tabCount = 0;

            foreach (string templine in code)
            {
                string line = templine.TrimStart('\t');
                if (line.StartsWith("endif") || line.StartsWith("endw") || line.StartsWith("elseif") || line.Contains("}"))
                    tabCount--;
                result.Add(Tabify(templine, tabCount));
                if (line.StartsWith("if") || line.StartsWith("while") || line.StartsWith("elseif") || line.Contains("{"))
                    tabCount++;
            }
            return result.ToArray <string>();
        }

        private string Tabify(string line, int count)
        {
            string result = "";
            for (int t1 = 0; t1 < count; t1++) result += "   ";
            return result + line;
        } 


    }
}
