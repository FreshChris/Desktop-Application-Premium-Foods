using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Premium_Foods_2023
{
    

    public partial class customers : Form
    {
        OleDbConnection cust = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\HND in Computing\Year 2 Semester 2\Dev App\Premium Foods 2023\customers_tbl.accdb");

        int checker;

        public customers()
        {
            InitializeComponent();
        }

        void dataviewer()
        {
            try
            {

                cust.Open();
                OleDbCommand cmd = cust.CreateCommand();
                cmd.CommandText = add_customer_btn.Text;
                cmd.CommandText = "select * from customers_tbl";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                customer_datagrid.DataSource = dt;
                cust.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cust.Close();
            }
        }
            private void label1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gotoproducts_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products Form = new Products();
            Form.Show();
        }

        private void gotomenuu_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu Form = new Menu();
            Form.Show();
        }

        private void search_customer_btn_Click(object sender, EventArgs e)
        {
            checker = 0;

            try
            {

                cust.Open();
                OleDbCommand cmd = cust.CreateCommand();
                cmd.CommandText = add_customer_btn.Text;
                cmd.CommandText = "select * from customers_tbl where Postcode='" + search_customer_txt.Text + "' or FirstName='" + search_customer_txt.Text + "' or LastName='" + search_customer_txt.Text + "' or City='" + search_customer_txt.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                checker = Convert.ToInt32(dt.Rows.Count.ToString());
                customer_datagrid.DataSource = dt;
                cust.Close();
                if (checker ==0)
                {
                    MessageBox.Show("The Customer Doesn't exist", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    search_customer_txt.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cust.Close();
            }
        }

        private void remove_customer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                cust.Open();
                OleDbCommand cmd = cust.CreateCommand();
                cmd.CommandText = firstname_txt.Text;
                cmd.CommandText = "delete * from customers_tbl where FirstName='" + firstname_txt.Text + "'";
                cmd.ExecuteNonQuery();
                cust.Close();
                MessageBox.Show("Customer Record Successfully Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
                customerid_txt.Text = "";
                firstname_txt.Text = "";
                lastname_txt.Text = "";
                phone_number_txt.Text = "";
                dateofbirth_txt.Text = "";
                address_txt.Text = "";
                city_txt.Text = "";
                postcode_txt.Text = "";
                gender_txt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cust.Close();
            }
        }

        private void view_customer_btn_Click(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void update_customer_btn_Click(object sender, EventArgs e)
        {
            try
            {

                cust.Open();
                OleDbCommand cmd = cust.CreateCommand();
                cmd.CommandText = add_customer_btn.Text;
                cmd.CommandText = "update customers_tbl set FirstName='" + firstname_txt.Text + "' where LastName='" + lastname_txt.Text + "'";
                cmd.ExecuteNonQuery();
                cust.Close();
                MessageBox.Show("The customer was updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cust.Close();
            }
        }

        private void add_customer_btn_Click(object sender, EventArgs e)
        {
            try
            {

                cust.Open();
                OleDbCommand cmd = cust.CreateCommand();
                cmd.CommandText = add_customer_btn.Text;
                cmd.CommandText = "insert into customers_tbl(CustomerID,FirstName,LastName,PhoneNumber,DateOfBirth,Address,City,Postcode,Gender)values('" + customerid_txt.Text + "','" + firstname_txt.Text + "','" + lastname_txt.Text + "','" + phone_number_txt.Text + "','" + dateofbirth_txt.Text + "','" + address_txt.Text + "','" + city_txt.Text + "','" + postcode_txt.Text + "','" + gender_txt.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("The customer was registered.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cust.Close();
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cust.Close();
            }
        }

        private void customer_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                customerid_txt.Text = customer_datagrid.SelectedRows[0].Cells[0].Value.ToString();
                firstname_txt.Text = customer_datagrid.SelectedRows[0].Cells[1].Value.ToString();
                lastname_txt.Text = customer_datagrid.SelectedRows[0].Cells[2].Value.ToString();
                phone_number_txt.Text = customer_datagrid.SelectedRows[0].Cells[3].Value.ToString();
                dateofbirth_txt.Text = customer_datagrid.SelectedRows[0].Cells[4].Value.ToString();
                address_txt.Text = customer_datagrid.SelectedRows[0].Cells[5].Value.ToString();
                city_txt.Text = customer_datagrid.SelectedRows[0].Cells[6].Value.ToString();
                postcode_txt.Text = customer_datagrid.SelectedRows[0].Cells[7].Value.ToString();
                gender_txt.Text = customer_datagrid.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cust.Close();
            }
        }
    }
}
