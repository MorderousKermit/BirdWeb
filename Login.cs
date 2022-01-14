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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "6tkI7F6yKtH98Fns")
            {
                OS x = new OS();
                x.Show();
                SessionID z = new SessionID();
                z.Show();
                
            }
            else if (textBox1.Text == "bgHLe1cRcY8hh13N")
            {
                OS x = new OS();
                x.Show();
                SessionID z = new SessionID();
                z.Show();
            }
            else
            {
                MessageBox.Show("Zły login, spróbuj ponownie lub potwierdź login u administratora.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
