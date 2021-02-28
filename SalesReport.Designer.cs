namespace GermanD
{
    partial class SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSCustomers = new System.Windows.Forms.Button();
            this.buttonSProducts = new System.Windows.Forms.Button();
            this.buttonSSalesReport = new System.Windows.Forms.Button();
            this.buttonSSales = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(114, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sales Report";
            // 
            // buttonSCustomers
            // 
            this.buttonSCustomers.Location = new System.Drawing.Point(10, 128);
            this.buttonSCustomers.Name = "buttonSCustomers";
            this.buttonSCustomers.Size = new System.Drawing.Size(98, 43);
            this.buttonSCustomers.TabIndex = 32;
            this.buttonSCustomers.Text = "Customers";
            this.buttonSCustomers.UseVisualStyleBackColor = true;
            this.buttonSCustomers.Click += new System.EventHandler(this.buttonSCustomers_Click);
            // 
            // buttonSProducts
            // 
            this.buttonSProducts.Location = new System.Drawing.Point(10, 88);
            this.buttonSProducts.Name = "buttonSProducts";
            this.buttonSProducts.Size = new System.Drawing.Size(98, 43);
            this.buttonSProducts.TabIndex = 33;
            this.buttonSProducts.Text = "Products";
            this.buttonSProducts.UseVisualStyleBackColor = true;
            this.buttonSProducts.Click += new System.EventHandler(this.buttonSProducts_Click);
            // 
            // buttonSSalesReport
            // 
            this.buttonSSalesReport.Location = new System.Drawing.Point(10, 168);
            this.buttonSSalesReport.Name = "buttonSSalesReport";
            this.buttonSSalesReport.Size = new System.Drawing.Size(98, 43);
            this.buttonSSalesReport.TabIndex = 34;
            this.buttonSSalesReport.Text = "Sales Report";
            this.buttonSSalesReport.UseVisualStyleBackColor = true;
            this.buttonSSalesReport.Click += new System.EventHandler(this.buttonSSalesReport_Click);
            // 
            // buttonSSales
            // 
            this.buttonSSales.Location = new System.Drawing.Point(10, 48);
            this.buttonSSales.Name = "buttonSSales";
            this.buttonSSales.Size = new System.Drawing.Size(98, 43);
            this.buttonSSales.TabIndex = 35;
            this.buttonSSales.Text = "Sales";
            this.buttonSSales.UseVisualStyleBackColor = true;
            this.buttonSSales.Click += new System.EventHandler(this.buttonSSales_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Location = new System.Drawing.Point(10, 8);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(98, 43);
            this.buttonDashboard.TabIndex = 37;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(582, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(378, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSCustomers);
            this.Controls.Add(this.buttonSProducts);
            this.Controls.Add(this.buttonSSalesReport);
            this.Controls.Add(this.buttonSSales);
            this.Controls.Add(this.buttonDashboard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSCustomers;
        private System.Windows.Forms.Button buttonSProducts;
        private System.Windows.Forms.Button buttonSSalesReport;
        private System.Windows.Forms.Button buttonSSales;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}