using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class RudzikNET : Form
    {
        public RudzikNET()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MyWebBrowser.Refresh();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            MyWebBrowser.Navigate(TxtURL.Text);
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            MyWebBrowser.GoHome();
        }

        private void btnforward_Click(object sender, EventArgs e)
        {
            MyWebBrowser.GoForward();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MyWebBrowser.GoBack();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
