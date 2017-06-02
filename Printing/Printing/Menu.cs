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
    public partial class Menu : Form
    {
        public static Authorization FormAuthorization;
        public static Sells FormSells;

        public Menu()
        {
            InitializeComponent();

            FormSells = new Sells();

            FormAuthorization = new Authorization();

            FormAuthorization.ShowDialog();
        }

        private void Sells_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormSells.Show();
        }

        private void ExitFromAccount_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAuthorization.ShowDialog();
        }

        private void See_Click(object sender, EventArgs e)
        {

        }
    }
}
