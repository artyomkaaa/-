using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += Web_DocumentCompleted;
            Гугл.TabPages.Add("New Page");
            Гугл.SelectTab(i);
            Гугл.SelectedTab.Controls.Add(web);
            i += 1;
        }

        void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          Гугл.SelectedTab.Text = ((WebBrowser)Гугл.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if(toolStripTextBox1.Text !=null)
            {
                ((WebBrowser)Гугл.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
                
            }
            else
            { 
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)Гугл.SelectedTab.Controls[0]).GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ((WebBrowser)Гугл.SelectedTab.Controls[0]).GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ((WebBrowser)Гугл.SelectedTab.Controls[0]).Refresh();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (Гугл.TabPages.Count > 1)
            {
                Гугл.TabPages.RemoveAt(Гугл.SelectedIndex);
                Гугл.SelectTab(Гугл.TabPages.Count - 1);
                i -= 1;
            }
            else
                Application.Exit();
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                ((WebBrowser)Гугл.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
            }
        }

       
    }
}
