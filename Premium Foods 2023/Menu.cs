using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Premium_Foods_2023
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void close_txt_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void products_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products Form = new Products();
            Form.Show();
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customers Form = new customers();
            Form.Show();
        }
    }
}
