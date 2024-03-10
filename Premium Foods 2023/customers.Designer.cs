
namespace Premium_Foods_2023
{
    partial class customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customers));
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.customerid_txt = new System.Windows.Forms.TextBox();
            this.firstname_txt = new System.Windows.Forms.TextBox();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.phone_number_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.gender_txt = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.postcode_txt = new System.Windows.Forms.TextBox();
            this.customer_datagrid = new System.Windows.Forms.DataGridView();
            this.gotomenuu_btn = new System.Windows.Forms.Button();
            this.gotoproducts_btn = new System.Windows.Forms.Button();
            this.add_customer_btn = new System.Windows.Forms.Button();
            this.update_customer_btn = new System.Windows.Forms.Button();
            this.remove_customer_btn = new System.Windows.Forms.Button();
            this.search_customer_btn = new System.Windows.Forms.Button();
            this.view_customer_btn = new System.Windows.Forms.Button();
            this.dateofbirth_txt = new System.Windows.Forms.DateTimePicker();
            this.search_customer_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customer_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Customer Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(1299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Close";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date of birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gender";
            // 
            // customerid_txt
            // 
            this.customerid_txt.Location = new System.Drawing.Point(246, 220);
            this.customerid_txt.Name = "customerid_txt";
            this.customerid_txt.Size = new System.Drawing.Size(143, 22);
            this.customerid_txt.TabIndex = 9;
            // 
            // firstname_txt
            // 
            this.firstname_txt.Location = new System.Drawing.Point(246, 256);
            this.firstname_txt.Name = "firstname_txt";
            this.firstname_txt.Size = new System.Drawing.Size(143, 22);
            this.firstname_txt.TabIndex = 9;
            // 
            // lastname_txt
            // 
            this.lastname_txt.Location = new System.Drawing.Point(246, 288);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(143, 22);
            this.lastname_txt.TabIndex = 9;
            // 
            // phone_number_txt
            // 
            this.phone_number_txt.Location = new System.Drawing.Point(246, 322);
            this.phone_number_txt.Name = "phone_number_txt";
            this.phone_number_txt.Size = new System.Drawing.Size(143, 22);
            this.phone_number_txt.TabIndex = 9;
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(246, 387);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(143, 22);
            this.address_txt.TabIndex = 9;
            // 
            // gender_txt
            // 
            this.gender_txt.FormattingEnabled = true;
            this.gender_txt.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_txt.Location = new System.Drawing.Point(245, 469);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.Size = new System.Drawing.Size(78, 24);
            this.gender_txt.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Postcode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "City";
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(246, 417);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(143, 22);
            this.city_txt.TabIndex = 9;
            // 
            // postcode_txt
            // 
            this.postcode_txt.Location = new System.Drawing.Point(246, 443);
            this.postcode_txt.Name = "postcode_txt";
            this.postcode_txt.Size = new System.Drawing.Size(143, 22);
            this.postcode_txt.TabIndex = 9;
            // 
            // customer_datagrid
            // 
            this.customer_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customer_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_datagrid.Location = new System.Drawing.Point(410, 220);
            this.customer_datagrid.Name = "customer_datagrid";
            this.customer_datagrid.RowHeadersWidth = 51;
            this.customer_datagrid.RowTemplate.Height = 24;
            this.customer_datagrid.Size = new System.Drawing.Size(918, 271);
            this.customer_datagrid.TabIndex = 11;
            this.customer_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_datagrid_CellClick);
            // 
            // gotomenuu_btn
            // 
            this.gotomenuu_btn.Location = new System.Drawing.Point(12, 12);
            this.gotomenuu_btn.Name = "gotomenuu_btn";
            this.gotomenuu_btn.Size = new System.Drawing.Size(138, 41);
            this.gotomenuu_btn.TabIndex = 12;
            this.gotomenuu_btn.Text = "Page Menu";
            this.gotomenuu_btn.UseVisualStyleBackColor = true;
            this.gotomenuu_btn.Click += new System.EventHandler(this.gotomenuu_btn_Click);
            // 
            // gotoproducts_btn
            // 
            this.gotoproducts_btn.Location = new System.Drawing.Point(199, 12);
            this.gotoproducts_btn.Name = "gotoproducts_btn";
            this.gotoproducts_btn.Size = new System.Drawing.Size(138, 41);
            this.gotoproducts_btn.TabIndex = 12;
            this.gotoproducts_btn.Text = "Page Products";
            this.gotoproducts_btn.UseVisualStyleBackColor = true;
            this.gotoproducts_btn.Click += new System.EventHandler(this.gotoproducts_btn_Click);
            // 
            // add_customer_btn
            // 
            this.add_customer_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_customer_btn.Image")));
            this.add_customer_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_customer_btn.Location = new System.Drawing.Point(410, 508);
            this.add_customer_btn.Name = "add_customer_btn";
            this.add_customer_btn.Size = new System.Drawing.Size(79, 31);
            this.add_customer_btn.TabIndex = 13;
            this.add_customer_btn.Text = "Add";
            this.add_customer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_customer_btn.UseVisualStyleBackColor = true;
            this.add_customer_btn.Click += new System.EventHandler(this.add_customer_btn_Click);
            // 
            // update_customer_btn
            // 
            this.update_customer_btn.Image = ((System.Drawing.Image)(resources.GetObject("update_customer_btn.Image")));
            this.update_customer_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update_customer_btn.Location = new System.Drawing.Point(538, 508);
            this.update_customer_btn.Name = "update_customer_btn";
            this.update_customer_btn.Size = new System.Drawing.Size(75, 31);
            this.update_customer_btn.TabIndex = 13;
            this.update_customer_btn.Text = "Update ";
            this.update_customer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_customer_btn.UseVisualStyleBackColor = true;
            this.update_customer_btn.Click += new System.EventHandler(this.update_customer_btn_Click);
            // 
            // remove_customer_btn
            // 
            this.remove_customer_btn.Image = ((System.Drawing.Image)(resources.GetObject("remove_customer_btn.Image")));
            this.remove_customer_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_customer_btn.Location = new System.Drawing.Point(655, 508);
            this.remove_customer_btn.Name = "remove_customer_btn";
            this.remove_customer_btn.Size = new System.Drawing.Size(81, 31);
            this.remove_customer_btn.TabIndex = 13;
            this.remove_customer_btn.Text = "Remove";
            this.remove_customer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove_customer_btn.UseVisualStyleBackColor = true;
            this.remove_customer_btn.Click += new System.EventHandler(this.remove_customer_btn_Click);
            // 
            // search_customer_btn
            // 
            this.search_customer_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_customer_btn.Image")));
            this.search_customer_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_customer_btn.Location = new System.Drawing.Point(1253, 508);
            this.search_customer_btn.Name = "search_customer_btn";
            this.search_customer_btn.Size = new System.Drawing.Size(75, 31);
            this.search_customer_btn.TabIndex = 13;
            this.search_customer_btn.Text = "Search";
            this.search_customer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_customer_btn.UseVisualStyleBackColor = true;
            this.search_customer_btn.Click += new System.EventHandler(this.search_customer_btn_Click);
            // 
            // view_customer_btn
            // 
            this.view_customer_btn.BackColor = System.Drawing.SystemColors.Control;
            this.view_customer_btn.Image = ((System.Drawing.Image)(resources.GetObject("view_customer_btn.Image")));
            this.view_customer_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.view_customer_btn.Location = new System.Drawing.Point(414, 183);
            this.view_customer_btn.Name = "view_customer_btn";
            this.view_customer_btn.Size = new System.Drawing.Size(75, 31);
            this.view_customer_btn.TabIndex = 13;
            this.view_customer_btn.Text = "View";
            this.view_customer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_customer_btn.UseVisualStyleBackColor = false;
            this.view_customer_btn.Click += new System.EventHandler(this.view_customer_btn_Click);
            // 
            // dateofbirth_txt
            // 
            this.dateofbirth_txt.Location = new System.Drawing.Point(246, 354);
            this.dateofbirth_txt.Name = "dateofbirth_txt";
            this.dateofbirth_txt.Size = new System.Drawing.Size(143, 22);
            this.dateofbirth_txt.TabIndex = 14;
            // 
            // search_customer_txt
            // 
            this.search_customer_txt.Location = new System.Drawing.Point(1147, 508);
            this.search_customer_txt.Multiline = true;
            this.search_customer_txt.Name = "search_customer_txt";
            this.search_customer_txt.Size = new System.Drawing.Size(100, 30);
            this.search_customer_txt.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(971, 515);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Search By Postcode or City";
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1357, 643);
            this.Controls.Add(this.search_customer_txt);
            this.Controls.Add(this.dateofbirth_txt);
            this.Controls.Add(this.view_customer_btn);
            this.Controls.Add(this.search_customer_btn);
            this.Controls.Add(this.remove_customer_btn);
            this.Controls.Add(this.update_customer_btn);
            this.Controls.Add(this.add_customer_btn);
            this.Controls.Add(this.gotoproducts_btn);
            this.Controls.Add(this.gotomenuu_btn);
            this.Controls.Add(this.customer_datagrid);
            this.Controls.Add(this.gender_txt);
            this.Controls.Add(this.postcode_txt);
            this.Controls.Add(this.city_txt);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.phone_number_txt);
            this.Controls.Add(this.lastname_txt);
            this.Controls.Add(this.firstname_txt);
            this.Controls.Add(this.customerid_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customers";
            ((System.ComponentModel.ISupportInitialize)(this.customer_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox customerid_txt;
        private System.Windows.Forms.TextBox firstname_txt;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.TextBox phone_number_txt;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.ComboBox gender_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.TextBox postcode_txt;
        private System.Windows.Forms.DataGridView customer_datagrid;
        private System.Windows.Forms.Button gotomenuu_btn;
        private System.Windows.Forms.Button gotoproducts_btn;
        private System.Windows.Forms.Button add_customer_btn;
        private System.Windows.Forms.Button update_customer_btn;
        private System.Windows.Forms.Button remove_customer_btn;
        private System.Windows.Forms.Button search_customer_btn;
        private System.Windows.Forms.Button view_customer_btn;
        private System.Windows.Forms.DateTimePicker dateofbirth_txt;
        private System.Windows.Forms.TextBox search_customer_txt;
        private System.Windows.Forms.Label label12;
    }
}