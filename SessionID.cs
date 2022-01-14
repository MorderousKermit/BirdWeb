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
    public partial class SessionID : Form
    {
        public SessionID()
        {
            InitializeComponent();
            Random random = new Random();
            int randomNumber = random.Next(100000000, 999999999);
            label1.Text = randomNumber.ToString();
        }

        private void SessionID_Load(object sender, EventArgs e)
        {
        }
    }
}
