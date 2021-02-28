namespace GermanD
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSSales = new System.Windows.Forms.Button();
            this.buttonSSalesReport = new System.Windows.Forms.Button();
            this.buttonSProducts = new System.Windows.Forms.Button();
            this.buttonSCustomers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.TextBoxCustomer_ID = new System.Windows.Forms.TextBox();
            this.TextBoxCustomer_Email = new System.Windows.Forms.TextBox();
            this.TextBoxCustomer_Mobile = new System.Windows.Forms.TextBox();
            this.TextBoxCustomer_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxCustomer_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextBoxForSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(593, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Location = new System.Drawing.Point(21, 21);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(98, 43);
            this.buttonDashboard.TabIndex = 27;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(667, 131);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 30);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSSales
            // 
            this.buttonSSales.Location = new System.Drawing.Point(21, 61);
            this.buttonSSales.Name = "buttonSSales";
            this.buttonSSales.Size = new System.Drawing.Size(98, 43);
            this.buttonSSales.TabIndex = 25;
            this.buttonSSales.Text = "Sales";
            this.buttonSSales.UseVisualStyleBackColor = true;
            this.buttonSSales.Click += new System.EventHandler(this.buttonSSales_Click);
            // 
            // buttonSSalesReport
            // 
            this.buttonSSalesReport.Location = new System.Drawing.Point(21, 181);
            this.buttonSSalesReport.Name = "buttonSSalesReport";
            this.buttonSSalesReport.Size = new System.Drawing.Size(98, 43);
            this.buttonSSalesReport.TabIndex = 24;
            this.buttonSSalesReport.Text = "Sales Report";
            this.buttonSSalesReport.UseVisualStyleBackColor = true;
            this.buttonSSalesReport.Click += new System.EventHandler(this.buttonSSalesReport_Click);
            // 
            // buttonSProducts
            // 
            this.buttonSProducts.Location = new System.Drawing.Point(21, 101);
            this.buttonSProducts.Name = "buttonSProducts";
            this.buttonSProducts.Size = new System.Drawing.Size(98, 43);
            this.buttonSProducts.TabIndex = 23;
            this.buttonSProducts.Text = "Products";
            this.buttonSProducts.UseVisualStyleBackColor = true;
            this.buttonSProducts.Click += new System.EventHandler(this.buttonSProducts_Click);
            // 
            // buttonSCustomers
            // 
            this.buttonSCustomers.Location = new System.Drawing.Point(21, 141);
            this.buttonSCustomers.Name = "buttonSCustomers";
            this.buttonSCustomers.Size = new System.Drawing.Size(98, 43);
            this.buttonSCustomers.TabIndex = 22;
            this.buttonSCustomers.Text = "Customers";
            this.buttonSCustomers.UseVisualStyleBackColor = true;
            this.buttonSCustomers.Click += new System.EventHandler(this.buttonSCustomers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(125, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Customers";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(342, 309);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(83, 33);
            this.buttonUpdate.TabIndex = 112;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // TextBoxCustomer_ID
            // 
            this.TextBoxCustomer_ID.Location = new System.Drawing.Point(239, 181);
            this.TextBoxCustomer_ID.Name = "TextBoxCustomer_ID";
            this.TextBoxCustomer_ID.Size = new System.Drawing.Size(186, 20);
            this.TextBoxCustomer_ID.TabIndex = 98;
            // 
            // TextBoxCustomer_Email
            // 
            this.TextBoxCustomer_Email.Location = new System.Drawing.Point(239, 233);
            this.TextBoxCustomer_Email.Name = "TextBoxCustomer_Email";
            this.TextBoxCustomer_Email.Size = new System.Drawing.Size(186, 20);
            this.TextBoxCustomer_Email.TabIndex = 100;
            // 
            // TextBoxCustomer_Mobile
            // 
            this.TextBoxCustomer_Mobile.Location = new System.Drawing.Point(239, 283);
            this.TextBoxCustomer_Mobile.Multiline = true;
            this.TextBoxCustomer_Mobile.Name = "TextBoxCustomer_Mobile";
            this.TextBoxCustomer_Mobile.Size = new System.Drawing.Size(186, 20);
            this.TextBoxCustomer_Mobile.TabIndex = 103;
            // 
            // TextBoxCustomer_Address
            // 
            this.TextBoxCustomer_Address.Location = new System.Drawing.Point(239, 259);
            this.TextBoxCustomer_Address.Multiline = true;
            this.TextBoxCustomer_Address.Name = "TextBoxCustomer_Address";
            this.TextBoxCustomer_Address.Size = new System.Drawing.Size(186, 20);
            this.TextBoxCustomer_Address.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(127, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "Customer ID";
            // 
            // TextBoxCustomer_Name
            // 
            this.TextBoxCustomer_Name.Location = new System.Drawing.Point(239, 207);
            this.TextBoxCustomer_Name.Name = "TextBoxCustomer_Name";
            this.TextBoxCustomer_Name.Size = new System.Drawing.Size(186, 20);
            this.TextBoxCustomer_Name.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(127, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 113;
            this.label10.Text = "Mobile Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(127, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 110;
            this.label8.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(127, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(127, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(127, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "ADD Customers";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(239, 309);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 33);
            this.buttonAdd.TabIndex = 112;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(239, 348);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 33);
            this.buttonDelete.TabIndex = 112;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(451, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 254);
            this.dataGridView1.TabIndex = 116;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TextBoxForSearch
            // 
            this.TextBoxForSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxForSearch.Location = new System.Drawing.Point(451, 133);
            this.TextBoxForSearch.Name = "TextBoxForSearch";
            this.TextBoxForSearch.Size = new System.Drawing.Size(199, 21);
            this.TextBoxForSearch.TabIndex = 117;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxForSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.TextBoxCustomer_ID);
            this.Controls.Add(this.TextBoxCustomer_Email);
            this.Controls.Add(this.TextBoxCustomer_Mobile);
            this.Controls.Add(this.TextBoxCustomer_Address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxCustomer_Name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSCustomers);
            this.Controls.Add(this.buttonSProducts);
            this.Controls.Add(this.buttonSSalesReport);
            this.Controls.Add(this.buttonSSales);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDashboard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSSales;
        private System.Windows.Forms.Button buttonSSalesReport;
        private System.Windows.Forms.Button buttonSProducts;
        private System.Windows.Forms.Button buttonSCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox TextBoxCustomer_ID;
        private System.Windows.Forms.TextBox TextBoxCustomer_Email;
        private System.Windows.Forms.TextBox TextBoxCustomer_Mobile;
        private System.Windows.Forms.TextBox TextBoxCustomer_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxCustomer_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TextBoxForSearch;
    }
}