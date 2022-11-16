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
namespace Seminar
{
    public partial class Form1 : Form
    {
        string saved = "";
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, to;
            if (fromTb.Text == "")
            {
                from = listBoxFrom.SelectedItem.ToString();
            }
            else
                from = fromTb.Text;
            if (toTb.Text == "")
                to = listBoxTo.SelectedItem.ToString();
            else
                to = toTb.Text;
            if (to == from)
                MessageBox.Show("Same currency selected!", "Warning");
            else
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate("www.google.com/search?q=" + amountTb.Text + " " + from + " in " + to + "&oq=" + amountTb.Text + " " + from + " in " + to);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void amountTb_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBoxHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter history = new StreamWriter("History.txt"))
            {
                string from, to;

                if (fromTb.Text == "")
                {
                    from = listBoxFrom.SelectedItem.ToString();
                }
                else
                    from = fromTb.Text;
                if (toTb.Text == "")
                    to = listBoxTo.SelectedItem.ToString();
                else
                    to = toTb.Text;
                saved += amountTb.Text + " " + from + " " + to+ "\r\n";
                history.WriteLine(saved);
                history.Flush();
                history.Close();
                i++;
            }
        }

        private void read_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("History.txt");
                string line = lines[i-2];
                string number = string.Empty;
                foreach (char c in line)
                {
                    number += c;
                    if (c == ' ')
                        break;
                }
                amountTb.Text = "";
                amountTb.AppendText(number);
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amountTb.Text = "";
            fromTb.Text = "";
            toTb.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_2(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
