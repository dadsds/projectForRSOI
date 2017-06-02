using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Printing
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            if (Login.Text == "admin" && Password.Text == "admin")
            {
                this.Hide();
            }
            else
            {
                Login.Text = "";
                Password.Text = "";

                MessageBox.Show("Login or Password is not true");
            }
        }
        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
