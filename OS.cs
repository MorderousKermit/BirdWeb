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
    public partial class OS : Form
    {
        public OS()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RudzikNET x = new RudzikNET();
            x.Show();
            OS z = new OS();
            z.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RudzikPAD x = new RudzikPAD();
            x.Show();
            OS z = new OS();
            z.Hide();
        }
    }
}
