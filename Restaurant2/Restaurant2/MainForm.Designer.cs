namespace Restaurant2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
       
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_category = new System.Windows.Forms.ComboBox();
            this.txtbx_admin = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_order);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbx_count);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbx_price);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbx_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbx_category);
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(136, 284);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(119, 23);
            this.btn_order.TabIndex = 8;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Count";
            // 
            // txtbx_count
            // 
            this.txtbx_count.Location = new System.Drawing.Point(89, 235);
            this.txtbx_count.Name = "txtbx_count";
            this.txtbx_count.Size = new System.Drawing.Size(211, 20);
            this.txtbx_count.TabIndex = 6;
            this.txtbx_count.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // txtbx_price
            // 
            this.txtbx_price.Location = new System.Drawing.Point(89, 186);
            this.txtbx_price.Name = "txtbx_price";
            this.txtbx_price.ReadOnly = true;
            this.txtbx_price.Size = new System.Drawing.Size(211, 20);
            this.txtbx_price.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // cmbx_name
            // 
            this.cmbx_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_name.FormattingEnabled = true;
            this.cmbx_name.Location = new System.Drawing.Point(89, 125);
            this.cmbx_name.Name = "cmbx_name";
            this.cmbx_name.Size = new System.Drawing.Size(211, 21);
            this.cmbx_name.TabIndex = 2;
            this.cmbx_name.SelectedValueChanged += new System.EventHandler(this.cmbx_name_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // cmbx_category
            // 
            this.cmbx_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_category.FormattingEnabled = true;
            this.cmbx_category.Location = new System.Drawing.Point(89, 61);
            this.cmbx_category.Name = "cmbx_category";
            this.cmbx_category.Size = new System.Drawing.Size(211, 21);
            this.cmbx_category.TabIndex = 0;
            this.cmbx_category.SelectedValueChanged += new System.EventHandler(this.cmbx_category_SelectedValueChanged);
            // 
            // txtbx_admin
            // 
            this.txtbx_admin.Location = new System.Drawing.Point(816, 40);
            this.txtbx_admin.Name = "txtbx_admin";
            this.txtbx_admin.ReadOnly = true;
            this.txtbx_admin.Size = new System.Drawing.Size(125, 20);
            this.txtbx_admin.TabIndex = 9;
            this.txtbx_admin.Text = "Log as Admin";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(497, 108);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(453, 254);
            this.dataGrid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(692, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Price:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(813, 379);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(19, 20);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 443);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.txtbx_admin);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_category;
        private System.Windows.Forms.TextBox txtbx_admin;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_price;
    }
}