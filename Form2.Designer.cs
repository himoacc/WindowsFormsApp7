
namespace WindowsFormsApp7
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.medicine_name = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtexp_date = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtmedicine = new System.Windows.Forms.TextBox();
            this.medicine = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.exp_date = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(492, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(603, 115);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(138, 35);
            this.search.TabIndex = 2;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(603, 376);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(138, 35);
            this.add.TabIndex = 3;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // medicine_name
            // 
            this.medicine_name.Location = new System.Drawing.Point(603, 61);
            this.medicine_name.Name = "medicine_name";
            this.medicine_name.Size = new System.Drawing.Size(138, 24);
            this.medicine_name.TabIndex = 5;
            this.medicine_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(603, 232);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(138, 24);
            this.txtprice.TabIndex = 6;
            // 
            // txtexp_date
            // 
            this.txtexp_date.Location = new System.Drawing.Point(603, 277);
            this.txtexp_date.Name = "txtexp_date";
            this.txtexp_date.Size = new System.Drawing.Size(138, 24);
            this.txtexp_date.TabIndex = 7;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(603, 324);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(138, 24);
            this.txtquantity.TabIndex = 8;
            // 
            // txtmedicine
            // 
            this.txtmedicine.Location = new System.Drawing.Point(603, 189);
            this.txtmedicine.Name = "txtmedicine";
            this.txtmedicine.Size = new System.Drawing.Size(138, 24);
            this.txtmedicine.TabIndex = 10;
            // 
            // medicine
            // 
            this.medicine.AutoSize = true;
            this.medicine.Location = new System.Drawing.Point(515, 192);
            this.medicine.Name = "medicine";
            this.medicine.Size = new System.Drawing.Size(61, 17);
            this.medicine.TabIndex = 11;
            this.medicine.Text = "medicine";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(515, 235);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(37, 17);
            this.price.TabIndex = 12;
            this.price.Text = "price";
            this.price.Click += new System.EventHandler(this.label1_Click);
            // 
            // exp_date
            // 
            this.exp_date.AutoSize = true;
            this.exp_date.Location = new System.Drawing.Point(515, 277);
            this.exp_date.Name = "exp_date";
            this.exp_date.Size = new System.Drawing.Size(66, 17);
            this.exp_date.TabIndex = 13;
            this.exp_date.Text = "exp_date";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(515, 327);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(59, 17);
            this.quantity.TabIndex = 14;
            this.quantity.Text = "quantity";
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(1, 376);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(111, 35);
            this.show.TabIndex = 15;
            this.show.Text = "show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.exp_date);
            this.Controls.Add(this.price);
            this.Controls.Add(this.medicine);
            this.Controls.Add(this.txtmedicine);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtexp_date);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.medicine_name);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox medicine_name;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtexp_date;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtmedicine;
        private System.Windows.Forms.Label medicine;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label exp_date;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Button show;
    }
}