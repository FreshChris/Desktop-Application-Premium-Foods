using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Premium_Foods_2023
{
    public partial class Products : Form
    {

        OleDbConnection prod = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\HND in Computing\Year 2 Semester 2\Dev App\Premium Foods 2023\products1.accdb");

        int checker;

        public Products()
        {
            InitializeComponent();
        }


        void dataviewer()
        {
            try
            {
                prod.Open();
                OleDbCommand cmd = prod.CreateCommand();
                cmd.CommandText = "select * from producttbl";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewproduct.DataSource = dt;
                prod.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prod.Close();
            }
        }


            private void close_label2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gotocustomer_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customers Form = new customers();
            Form.Show();
        }

        private void gotomenu_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu Form = new Menu();
            Form.Show();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                prod.Open();
                OleDbCommand cmd = prod.CreateCommand();
                cmd.CommandText = productname_txt.Text;
                cmd.CommandText = "delete * from producttbl where Name='" + productname_txt.Text + "'";
                cmd.ExecuteNonQuery();
                prod.Close();
                MessageBox.Show("Product Successfully deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
                id_product_txt.Text = "";
                productname_txt.Text = "";
                price_txt.Text = "";
                description_txt.Text = "";
                quantity_txt.Text = "";
                expirydateproducttxt.Text = "";
                comboBoxsuppliertxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prod.Close();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                prod.Open();
                OleDbCommand cmd = prod.CreateCommand();
                cmd.CommandText = "update producttbl set IDProduct='" + id_product_txt.Text + "' where Name= '" + productname_txt.Text + "'";
                cmd.ExecuteNonQuery();
                prod.Close();
                MessageBox.Show("Product Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prod.Close();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            checker = 0;

            try
            {
                prod.Open();
                OleDbCommand cmd = prod.CreateCommand();
                cmd.CommandText = "select * from producttbl where Name='" + productsearchtxt.Text + "' or Supplier='" + productsearchtxt.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                checker = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridViewproduct.DataSource = dt;
                prod.Close();

                if (checker == 0)
                {
                    MessageBox.Show("Record Not Found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productname_txt.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prod.Close();
            }
        }

        private void addproduct_btn_Click(object sender, EventArgs e)
        {
            try
            {
                prod.Open();
                OleDbCommand cmd = prod.CreateCommand();
                cmd.CommandText = addproduct_btn.Text;
                cmd.CommandText = "insert into producttbl(IDProduct,Name,Price,Description,Quantity,ExpiryDate,Supplier)values('" + id_product_txt.Text + "','" + productname_txt.Text + "','" + price_txt.Text + "','" + description_txt.Text + "','" + quantity_txt.Text + "','" + expirydateproducttxt.Text + "','" + comboBoxsuppliertxt.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
                prod.Close();
                dataviewer();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Product added successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prod.Close();
            }
        }

        private void dataGridViewproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_product_txt.Text = dataGridViewproduct.SelectedRows[0].Cells[0].Value.ToString();
            productname_txt.Text = dataGridViewproduct.SelectedRows[0].Cells[1].Value.ToString();
            price_txt.Text = dataGridViewproduct.SelectedRows[0].Cells[2].Value.ToString();
            description_txt.Text = dataGridViewproduct.SelectedRows[0].Cells[3].Value.ToString();
            quantity_txt.Text = dataGridViewproduct.SelectedRows[0].Cells[4].Value.ToString();
            expirydateproducttxt.Text = dataGridViewproduct.SelectedRows[0].Cells[5].ToString();
            comboBoxsuppliertxt.Text = dataGridViewproduct.SelectedRows[0].Cells[6].ToString();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            dataviewer();
        }
    }
}
